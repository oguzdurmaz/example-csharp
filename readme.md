Codecov C# Example
==================

| [https://codecov.io][1] | [@codecov][2] | [hello@codecov.io][3] |
| ----------------------- | ------------- | --------------------- |

This repository serves as an **example** on how to use [Codecov Global][4] for C#.

## Installation

You need to add two nuget packages to your Visual Studio solution:

The first package is [OpenCover][5] which will be used to generate code coverage analysis:
   
```
PM> Install-Package OpenCover
```

The second package is ??? which will be used to upload the XML file generated by [OpenCover][5] to Codecov.io:

```
PM> Install-Package ???
```


## Usage

Let's assume your C# solution has the following folder structure:

- C:\_build\MyProject\ --> this is your solution's root folder. For instance, this is where you have saved your visual studio solution (.sln) file.
- C:\_build\MyProject\packages\ --> this is where all nuget packages are downloaded
- C:\_build\MyProject\MyProject Unit Tests\ --> this is where your C# unit testing project is located (.csproj)

To generate code coverage analysis, execute the following comment from a command prompt in your solution's root:

```
.\packages\OpenCover.4.5.3522\OpenCover.Console.exe -register:user -target:"C:\Program Files (x86)\Microsoft Visual Studio 12.0\Common7\IDE\MSTest.exe" -targetargs:"/noresults /noisolation /testcontainer:"".\MyProject Unit Tests\bin\Debug\MyProject.UnitTests.dll" -filter:"+[MyProject]*  -[MyProject]MyProject.Properties.*" -excludebyattribute:*.ExcludeFromCodeCoverage* -hideskipped:All -output:.\MyProject_coverage.xml
```

This command makes a few assumptions which you will most likely have to adjust to meet your needs:

1. Use OpenCover v4.5.3522, which is the latest version as of this writing, to generate code coverage. Of course you will need to adjust the path to the OpenCover package when new versions are available. 
2. Unit tests are compiled in a DLL called .\MyProject Unit Tests\bin\Debug\MyProject.UnitTests.dll (replace 'Debug' with 'Release if you compile in 'Release' mode).  
3. Code coverage will include all classes, methods and properties under the [MyProject] namespace except [MyProject]MyProject.Properties. These properties, typically, include your project version number, compiler options, etc. and therefore should be excluded from the code coverage report.
4. Any class decorated with the 'ExcludeFromCodeCoverage' attribute is automatically excluded from the coverage analysis.
5. Code coverage analysis is written to a XML file called MyProject_coverage.xml  

Now that you have generated your code coverage analysis, you must upload it to CodeCov. Here's the command to do so:

```
???
```


View source and learn more about [Codecov Global Uploader][4]

[1]: https://codecov.io/
[2]: https://twitter.com/codecov
[3]: mailto:hello@codecov.io
[4]: https://github.com/codecov/codecov-bash
[5]: https://www.nuget.org/packages/OpenCover/