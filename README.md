Turn WPF binding errors into exceptions
=

This project demonstrates how you can easily convert WPF binding errors into exception.
    
![Exception show in Visual Studio](Pictures/XamlParseException.png)

You can use it in your project by adding a single line:
    
![Exception show in Visual Studio](Pictures/BindingExceptionThrowerAttach.png)

Content
-

 1. `WpfBindingError` contains the actual code that throws `BindingException`.
 2. `SampleWpfApplication` shows a `BindingException` at runtime
 3. `SampleWpfApplicationTest` shows how you can check the binding errors in a unit test project.