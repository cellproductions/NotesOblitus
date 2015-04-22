using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Timers;
using System.Windows.Forms;
using Timer = System.Timers.Timer;

namespace NotesOblitus
{
	class AutoScanScheduler
	{
		private class TimeEvent
		{
			public int Time { get; set; }
			public readonly List<ElapsedEventHandler> Events = new List<ElapsedEventHandler>();
		}

		private readonly Form _owner;
		private readonly Timer _autoTimer = new Timer();
		private readonly List<TimeEvent> _times = new List<TimeEvent>();
		private int _currentTime;
		private int _handlerCount;

		public AutoScanScheduler(Form owner)
		{
			_owner = owner;

			_autoTimer.AutoReset = true;
			_autoTimer.Elapsed += (sender, args) =>
			{
				lock (_times)
				{
					if (_times.Count <= 0)
						return;
					var index = _currentTime;
					++_currentTime;
					if (_currentTime >= _times.Count)
						_currentTime = 0;
					_autoTimer.Interval = _currentTime == 0 ? _times[_currentTime].Time : _times[_currentTime].Time - _times[index].Time;

					if (!_owner.IsDisposed) /** TODO(bug) this doesnt work. still throws exception when Owner has been closed */
					{
						_owner.Invoke(new MethodInvoker(() =>
						{
							foreach (var proc in _times[index].Events) /** TODO(threading) not sure if these should call in their own threads */
								proc(sender, args);
						}));
					}
				}
			};
		}

		public void StartScheduler()
		{
			_autoTimer.Start();
		}

		public void StopScheduler()
		{
			_autoTimer.Stop();
		}

		public bool IsRunning()
		{
			return _autoTimer.Enabled;
		}

		public void AddTime(int time, ElapsedEventHandler handler)
		{
#if DEBUG
			Debug.Assert(time >= 1000.0);
#endif
			lock (_times)
			{
				InsertTime(time, handler);
				++_handlerCount;

				if (!_autoTimer.Enabled)
					_autoTimer.Interval = _times[0].Time;
			}
		}

		private void InsertTime(int time, ElapsedEventHandler handler)
		{
			if (_times.Count <= 0)
			{
				var t = new TimeEvent { Time = time };
				t.Events.Add(handler);
				_times.Add(t);
				return;
			}

			var split = _times.Count / 2;
			var index = split;

			while (split != 0)
			{
				split /= 2;
				if (time > _times[index].Time)
					index += split;
				else if (time < _times[index].Time)
					index -= split;
				else // if the time already exists, just add the handler to that time's handler list
				{
					_times[index].Events.Add(handler);
					return;
				}
			}

			var timeevent = new TimeEvent { Time = time };
			timeevent.Events.Add(handler);
			_times.Insert(index, timeevent);
		}

		public void RemoveTime(int time)
		{
			lock (_times)
			{
				for (var i = 0; i < _times.Count; ++i)
				{
					if (_times[i].Time != time)
						continue;
					_handlerCount -= _times[i].Events.Count;
					_times.RemoveAt(i);
					return;
				}

				if (_times.Count <= 0)
					StopScheduler();
			}
		}

		public void RemoveTimeAt(int time, ElapsedEventHandler handler)
		{
			lock (_times)
			{
				// ReSharper disable once LoopCanBePartlyConvertedToQuery
				foreach (var timeevent in _times)
				{
					if (timeevent.Time != time)
						continue;
					if (timeevent.Events.Remove(handler))
						--_handlerCount;

					if (_handlerCount <= 0)
						StopScheduler();
					return;
				}
			}
		}
	}
}
