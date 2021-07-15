# MSC Development Guide

## Before we start

This guide assumes some basic skills like C# programming, 3D modelling and texturing with Blender, Unity 3D and other weird stuff we'll find on the road of making mods for My Summer Car.

First of all we know that MSC Pro will be the tool we use for loading our mods so we need to take a look the documentation. Luckily this step is well documented on that section oriented for creators. They ask us first for an .NET IDE. They explains step by step how to configure that with [Microsoft Visual Studio 2019 Community](https://visualstudio.microsoft.com/vs/community/). As we explained before we work with Visual Code so we need to translate those steps to our IDE.
Things we need to be care of:

* [Download .NET](https://dotnet.microsoft.com/download): make sure that ".NET Framework 3.5 development tools" is installed on your system.
* [C#](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp)
* [Unity Development with VS Code](https://code.visualstudio.com/docs/other/unity)
* [Debugger for Unity](https://marketplace.visualstudio.com/items?itemName=Unity.unity-debug)


## Visual Studio Code Template, is it possible?

Yep, but finally recommend strongly work with Visual Studio 2017 or 2019 as the developers of [Mod Loader Pro](https://mscloaderpro.github.io/docs/#/) suggest at their [documentation](https://mscloaderpro.github.io/docs/#/ForCreators/PreparingEnvironment). Btw you cand find a simple template that works without any problem at ``visual_code_tpl_mod`` folder. You need to build it following this commands:

```shell
$ mkdir visual_code_tpl_mod
$ cd visual_code_tpl_mod
$ dotnet new sln
$ dotnet new classlib -o sample
$ dotnet sln add sample\sample.csproj
```
