Turn WPF binding errors into exceptions
=

This project demonstrate out you can easily convert WPF binding errors into exception.
    
![Exception show in Visual Studio](Pictures/XamlParseException.png)

Integrating this in your project is as easy as:
    
![Exception show in Visual Studio](Pictures/BindingExceptionThrowerAttach.png)

Content
-

 1. `WpfBindingError` contains the actual code that throws `BindingException`.
 2. `SampleWpfApplication` shows a `BindingException` at runtime
 3. `SampleWpfApplicationTest` shows how you can check the binding errors in a unit test project.