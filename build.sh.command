cd `dirname $0`
/Applications/MonoDevelop.app/Contents/MacOS/mdtool build
mono "packages/NUnit.Runners.2.6.1/tools/nunit-console.exe" "MonoDevelopTesting/bin/Debug/MonoDevelopTesting.dll"
