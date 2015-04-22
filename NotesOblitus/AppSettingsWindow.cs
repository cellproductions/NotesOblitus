using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace NotesOblitus
{
	public partial class AppSettingsWindow : Form
	{
		public class UpdateClickedEventArgs : EventArgs
		{
			public bool UpdateFound { get; set; }
		}

		public delegate void UpdateClickedEvent(object sender, UpdateClickedEventArgs args);

		public event UpdateClickedEvent UpdateClicked;

		public AppSettingsWindow()
		{
			InitializeComponent();
		}

		public void InitialiseSettings(AppSettings settings, bool updateAvailable)
		{
			// proxy
			var prev = cProxyShowPwd.Checked;
			cProxyShowPwd.Checked = GetBoolFromOption(settings, "ShowPassword");
			if (cProxyShowPwd.Checked == prev && cProxyShowPwd.Enabled) // CheckedChanged wont be called if the value is the same was it was before
				cProxyShowPwd_CheckedChanged(cProxyShowPwd, new EventArgs());
			tbProxyUsername.Text = GetStringFromOption(settings, "ProxyUsername");
			tbProxyPassword.Text = GetStringFromOption(settings, "ProxyPassword");
			prev = cProxyDefaultCreds.Checked;
			cProxyDefaultCreds.Checked = GetBoolFromOption(settings, "UseDefaultCredentials");
			if (cProxyDefaultCreds.Checked == prev && cProxyDefaultCreds.Enabled) // CheckedChanged wont be called if the value is the same was it was before
				cProxyDefaultCreds_CheckedChanged(cProxyDefaultCreds, new EventArgs());
			prev = cProxyDefaultProxy.Checked;
			cProxyDefaultProxy.Checked = GetBoolFromOption(settings, "UseDefaultProxy");
			if (cProxyDefaultProxy.Checked == prev) // CheckedChanged wont be called if the value is the same was it was before
				cProxyDefaultProxy_CheckedChanged(cProxyDefaultProxy, new EventArgs());
			tbProxyAddress.Text = GetStringFromOption(settings, "ProxyAddress");
			tbProxyPort.Text = GetStringFromOption(settings, "ProxyPort");
			prev = cProxyUseProxy.Checked;
			cProxyUseProxy.Checked = GetBoolFromOption(settings, "UseProxy");
			if (cProxyUseProxy.Checked == prev) // CheckedChanged wont be called if the value is the same was it was before
				cProxyUseProxy_CheckedChanged(cProxyUseProxy, new EventArgs());

			cbUpdateUpdate.SelectedIndex = ValidOption(settings.UpdateMode) ? (int)UpdateStyle.None.Parse(settings.UpdateMode) : (int)UpdateStyle.None;
			bUpdateUpdate.Text = updateAvailable ? "Update available" : "No update available";
			bUpdateUpdate.ForeColor = updateAvailable ? Color.ForestGreen : Color.Firebrick;
			/** TODO(note) dont forget to change the update status button appropriately. should be disabled if Update is set to None (do not check) */
		}

		public AppSettings RetrieveSettings()
		{
			return new AppSettings
			{
				UseProxy = cProxyUseProxy.Checked.ToString(),
				UseDefaultProxy = cProxyDefaultProxy.Checked.ToString(),
				ProxyAddress = tbProxyAddress.Text,
				ProxyPort = tbProxyPort.Text,
				UseDefaultCredentials = cProxyDefaultCreds.Checked.ToString(),
				ShowPassword = cProxyShowPwd.Checked.ToString(),
				ProxyUsername = tbProxyUsername.Text,
				ProxyPassword = tbProxyPassword.Text,
				UpdateMode = UpdateStyleExtensions.FromInt(cbUpdateUpdate.SelectedIndex).ToString()
			};
		}

		private static bool GetBoolFromOption(AppSettings defaultOptions, string member)
		{
#if DEBUG
			string dvalue = null;
			try
			{
				dvalue = (string)defaultOptions.GetType().GetProperty(member).GetValue(defaultOptions);
			}
			catch (Exception e)
			{
				Debug.Fail(e.ToString());
			}
#else
			var dvalue = (string)defaultOptions.GetType().GetProperty(member).GetValue(defaultOptions);
#endif

			return ValidOption(dvalue) && bool.Parse(dvalue);
		}

		private static string GetStringFromOption(AppSettings defaultOptions, string member)
		{
#if DEBUG
			string dvalue = null;
			try
			{
				dvalue = (string)defaultOptions.GetType().GetProperty(member).GetValue(defaultOptions);
			}
			catch (Exception e)
			{
				Debug.Fail(e.ToString());
			}
#else
			var dvalue = (string)defaultOptions.GetType().GetProperty(member).GetValue(defaultOptions);
#endif

			return ValidOption(dvalue) ? dvalue : "";
		}

		private static bool ValidOption(string value)
		{
			return !string.IsNullOrEmpty(value);
		}

		private void bUpdateCheckUpdate_Click(object sender, EventArgs e)
		{
			if (UpdateClicked == null)
				return;

			bUpdateCheckUpdate.Enabled = false;
			var args = new UpdateClickedEventArgs();
			UpdateClicked(bUpdateCheckUpdate, args);
			bUpdateCheckUpdate.Enabled = true;

			bUpdateUpdate.Text = args.UpdateFound ? "Update available" : "No update available";
			bUpdateUpdate.ForeColor = args.UpdateFound ? Color.ForestGreen : Color.Firebrick;
		}

		private void cProxyUseProxy_CheckedChanged(object sender, EventArgs e)
		{
			var check = cProxyUseProxy.Checked;
			tbProxyAddress.Enabled = check;
			tbProxyPort.Enabled = check;
			cProxyShowPwd.Enabled = check;
			tbProxyUsername.Enabled = check;
			tbProxyPassword.Enabled = check;
			cProxyDefaultProxy.Enabled = check;
			if (!cProxyDefaultProxy.Enabled)
				cProxyDefaultCreds.Enabled = check;
		}

		private void cProxyDefaultProxy_EnabledChanged(object sender, EventArgs e)
		{
			if (cProxyDefaultProxy.Enabled)
				cProxyDefaultProxy_CheckedChanged(sender, e);
		}

		private void cProxyDefaultProxy_CheckedChanged(object sender, EventArgs e)
		{
			var check = !cProxyDefaultProxy.Checked;
			tbProxyAddress.Enabled = check;
			tbProxyPort.Enabled = check;
			cProxyShowPwd.Enabled = check;
			tbProxyUsername.Enabled = check;
			tbProxyPassword.Enabled = check;
			cProxyDefaultCreds.Enabled = check;
		}

		private void cProxyDefaultCreds_EnabledChanged(object sender, EventArgs e)
		{
			if (cProxyDefaultCreds.Enabled)
				cProxyDefaultCreds_CheckedChanged(sender, e);
		}

		private void cProxyDefaultCreds_CheckedChanged(object sender, EventArgs e)
		{
			var check = !cProxyDefaultCreds.Checked;
			tbProxyUsername.Enabled = check;
			tbProxyPassword.Enabled = check;
		}

		private void cProxyShowPwd_CheckedChanged(object sender, EventArgs e)
		{
			tbProxyPassword.UseSystemPasswordChar = !cProxyShowPwd.Checked;
		}
	}
}
