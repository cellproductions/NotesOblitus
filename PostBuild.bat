:: Arg 1 is the Release dir, arg 2 is the name of the exe to merge, arg 3 is the solution dir
:: Clear out the Export folder, rd removes the dir, gets remade with mkdir
echo Arg[0]: %1
echo Arg[1]: %2
echo Arg[2]: %3
echo ExportPath: %3Export
echo Preparing paths
cd %3Export
del /s /q *.*
rd /s /q %3Export
mkdir %3Export
:: Merge dlls and the exe together
echo Merging assemblies
cd %1
%3packages\ilmerge.2.14.1208\tools\ILMerge.exe %2 Newtonsoft.Json.dll /out:NotesOblitus.exe
:: Copy all the relavant files to the Export folder
echo Copying paths to Export
cd %3
xcopy %1*.* %3Export /s /e /exclude:CopyFilter.txt
"C:\Users\Callum\Documents\Visual Studio 2013\Projects\NotesOblitus\ManifestBuilder\bin\Release\ManifestBuilder.exe" %3Export
xcopy %3Patcher\bin\Release\Patcher.exe %3Export