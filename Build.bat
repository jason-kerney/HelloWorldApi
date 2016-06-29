@echo off
rem Reset the color because build script may mess it up.
Color 07

rem if no argument was given choose default
if "%1"=="" (set para="Default") else set para=%1 

cls

rem grab FSharp Make and install it to local directory from Nuget
".nuget\NuGet.exe" "Install" "FAKE" "-OutputDirectory" "packages" "-ExcludeVersion"

rem call FSharp make with build script
"packages\FAKE\tools\Fake.exe" build.fsx %para%
pause