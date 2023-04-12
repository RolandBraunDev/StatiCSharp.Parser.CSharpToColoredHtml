# C# to colored HTML parser

This is a port of [Swiftly1](https://github.com/Swiftly1)'s [CsharpToColouredHTML](https://www.nuget.org/packages/CsharpToColouredHTML.Core) for [StatiC#](https://www.nuget.org/packages/StatiCSharp), a static website generator for C# developers. Requiring StatiC# 0.4.0 or higher.

By injecting this parser into StatiC#'s website-generating process all C# code parts of your markdown files are rendered to look as if it was inside Visual Studio or Visual Studio Code.

## How to use

Initiate a new instance of the parser. It's optional to disable line numbers in the output. Then  inject the parser into StatiC#'s website manager:

```C#
using StatiCSharp.Parser.CSharpToColoredHtmlParser;

// ...

var parser = new CSharpToColoredHtmlParser()
    .DisableLineNumbers();                      // Optional

manager.AddParser(parser);

await manager.Make();
```

You have to mark the code parts in the markdown files:

```
Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt  
ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation  
ullamco laboris nisi ut aliquip ex ea commodo consequat.

```C#
// Your C# code in here...
`` ``` ``

Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt  
ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation  
ullamco laboris nisi ut aliquip ex ea commodo consequat.
```

## CsharpToColouredHTML

=> Check out the original project of Swiftly1 here: [Link](https://www.nuget.org/packages/CsharpToColouredHTML.Core)