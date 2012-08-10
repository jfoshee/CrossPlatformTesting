## Cross-Platform C# Testing Experiment

The goal of this project is to find an approach for cross-compiling C# Unit Tests to run on (at least) three platforms:

1. Microsoft Visual Studio on Windows
2. MonoDevelop on Mac
3. MonoTouch on iOS (Simulator and Hardware)

Additionally,

1. No preprocessor directives 
2. Maintain the "native" experience of running tests in the local environment

So far these goals have been met, in large part thanks to the [Fluent Assertions][1] project. The main feature there is abstraction away from and run-time detection of the available assertion framework.

### Guided Tour of the Code

- [CrossPlatformTesting / VisualStudioTesting / WidgetTest.cs][2] has the unit testing code.
- The MonoTouchTesting and MonoDevelopTesting projects have a link to the WidgetTest file.
- Because the Mono tests depend on NUnit, they reference [a shim][3] which subclasses the NUnit attributes so they are named as the MSTest attributes.

It is worth noting that Any CPU assemblies (via MonoTouch) can be run on the iOS Simulator.  However, to run on the iOS hardware the code must be built from a MonoTouch project. (Sadly "Any CPU" is not actually *Any* CPU.)  Thus, this project includes a MonoTouch build of FluentAssertions.

[1]: http://fluentassertions.codeplex.com
[2]: https://github.com/jfoshee/CrossPlatformTesting/blob/master/VisualStudioTesting/WidgetTest.cs
[3]: https://github.com/jfoshee/CrossPlatformTesting/blob/master/MonoDevelopTesting/MicrosoftToNunitAttributeShims.cs

