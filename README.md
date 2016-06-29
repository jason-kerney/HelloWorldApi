# HelloWorldApi
A tutorial on how to publish a C# API to [NuGet](https://www.nuget.org/)

<a rel="license" href="http://creativecommons.org/licenses/by-sa/4.0/"><img alt="Creative Commons License" style="border-width:0" src="https://i.creativecommons.org/l/by-sa/4.0/88x31.png" /></a><br />This work is licensed under a <a rel="license" href="http://creativecommons.org/licenses/by-sa/4.0/">Creative Commons Attribution-ShareAlike 4.0 International License</a>.

## My Tool Chain ##
* [Git Hub](https://github.com/jason-kerney/HelloWorldApi)
* [FSharp Make (Fake)](http://fsharp.github.io/FAKE/)
* [Visual Studio Community Edition (2015)](https://www.visualstudio.com/en-us/products/visual-studio-community-vs.aspx)
* [GitKraken Git Gui](https://www.gitkraken.com/)
* [Notepad ++](https://notepad-plus-plus.org/)
* [NuGet Package Explorer](https://github.com/NuGetPackageExplorer/NuGetPackageExplorer)
* _[Stack Edit Mark Down Editor](https://stackedit.io/editor) to write this documentation._

##Goals##
We will take an existing C# API and write an automated script to compile it, test it and deploy it to NuGet.

###Take an existing C# API###
This will be checked in with the HelloWorld API project and tests. This very simple project will allow us to explore everything we need to do to automate a publish to NuGet.

###Automated Compilation##
**Tools:**
 * [Fake](http://fsharp.github.io/FAKE/)
 * Batch Scripts

 **Build.bat**
 This file will be used to consistently launch the build process.
 
```dos
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
```