Turn WPF binding errors into exceptions
=

This project demonstrates how you can easily convert WPF binding errors into exception.
    
![Exception show in Visual Studio](SampleWpfApplication/Pictures/XamlParseException.png)

All it requires is adding a single line in your existing code.
    
![Exception show in Visual Studio](SampleWpfApplication/Pictures/BindingExceptionThrowerAttach.png)

Content
-

 1. Project `WpfBindingError` contains the actual code that throws `BindingException`.
 2. Project `SampleWpfApplication` shows a `BindingException` at runtime
 3. Project `SampleWpfApplicationTest` shows how you can check the binding errors in a **unit test project**.