Turn WPF binding errors into exceptions
=

This project demonstrates how you can easily convert WPF binding errors into exception.
    
![Exception show in Visual Studio](SampleWpfApplication/Pictures/XamlParseException.png)

All it requires is a single line in your existing code.
    
```csharp
public partial class App : Application
{
    protected override void OnStartup(StartupEventArgs args)
    {
        base.OnStartup(args);
        
        // start listening for WPF binding error
        // after that line, a BindingException will be thrown each time
        // a binding error occurs.
        BindingExceptionThrower.Attach();
    }
}
```

Install with NuGet:
-

    PM> Install-Package WpfBindingErrors

https://www.nuget.org/packages/WpfBindingErrors


Content
-

 1. [Project WpfBindingError](WpfBindingErrors) is a reusable assembly that listens for binding errors.
 2. [Project SampleWpfApplication](SampleWpfApplication) shows how to throw `BindingException` at **runtime**.
 3. [Project SampleWpfApplicationTests](SampleWpfApplicationTests) shows how to check binding errors in a **unit test project**.
 
Each project contains its own README, please check.
