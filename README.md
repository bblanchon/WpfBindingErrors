Turn WPF binding errors into exceptions
=======================================

A lightweight library that converts WPF binding errors into exceptions, so you can quickly spot errors in the XAML markup and detect them unit tests.
    
![Exception shown in Visual Studio](SampleWpfApplication/Pictures/XamlParseException.png)

All it requires is a single line in your existing code:
    
```csharp
public partial class App : Application
{
    protected override void OnStartup(StartupEventArgs args)
    {
        base.OnStartup(args);
        
        // Start listening for WPF binding error.
        // After that line, a BindingException will be thrown each time
        // a binding error occurs.
        BindingExceptionThrower.Attach();
    }
}
```

Installing:
-----------

With .NET CLI

    > dotnet add package WpfBindingErrors

With Package Manager:

    PM> Install-Package WpfBindingErrors

https://www.nuget.org/packages/WpfBindingErrors


Content
-------

 1. [Project WpfBindingError](WpfBindingErrors) is a reusable assembly that listens for binding errors.
 2. [Project SampleWpfApplication](SampleWpfApplication) shows how to throw `BindingException` at **runtime**.
 3. [Project SampleWpfApplicationTests](SampleWpfApplicationTests) shows how to check binding errors in a **unit test project**.
 
Each project contains a dedicated README with more detail.

Supported frameworks
--------------------

* .NET 8 (net8.0-windows)
* .NET Framework 4.8 (net48)

Contributors
------------

* [Gareth Brown](https://github.com/wonea)
* [Bruno Juchli](https://github.com/jongleur1983)
* [David Neale](https://github.com/davidneale)
