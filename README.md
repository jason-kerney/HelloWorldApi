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
 * [NuGet](https://www.nuget.org/)
 * [Fake](http://fsharp.github.io/FAKE/)
 * PowerShell
 * Batch Script

####1. Download NuGet Executable####
Download the commadline from: [The Nuget Reference](https://docs.nuget.org/consume/command-line-reference) or the [Direct Download](https://dist.nuget.org/win-x86-commandline/latest/nuget.exe) and place it into the project dircetory, under its own directory. I used the name **_.nuget_** for the directory in this project. 

**Creating the _.nuget_ folder**
From a command shell
```dos
mkdir .nuget
```
From power shell
```powershell
New-Item .\.nuget -type directory
```
####2. Setup initial batch file####
