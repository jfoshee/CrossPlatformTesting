CALL    "%ProgramFiles(x86)%\Microsoft Visual Studio 10.0\VC\vcvarsall.bat" x86
MSBUILD windows.msbuild
MSTEST  /testcontainer:VisualStudioTesting\bin\Debug\VisualStudioTesting.dll
"packages\NUnit.Runners.2.6.1\tools\nunit-console.exe" "MonoDevelopTesting\bin\Debug\MonoDevelopTesting.dll"
PAUSE
