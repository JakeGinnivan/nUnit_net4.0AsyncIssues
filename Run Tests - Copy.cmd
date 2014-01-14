"C:\Windows\Microsoft.NET\Framework\v4.0.30319\msbuild.exe" "%~dp0\WpfApplication4.sln"
 
"%~dp0\NUnit-2.6.2\bin\nunit-console.exe" "%~dp0\ClassLibrary1\bin\Debug\ClassLibrary1.dll"
 
if %errorlevel% neq 0 echo nUnit exited with non-zero return code: %errorlevel%
 
pause