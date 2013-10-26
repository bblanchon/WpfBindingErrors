Turn WPF binding errors into exceptions
=

This project demonstrates how to use `BindingExceptionThrower` in a WPF application.

I deliberately inserted an invalid binding in `MainWindow.xaml`. Indeed `{Binding BadBinding}` refers to a property that doesn't exists in class `ViewModel`.

If you run this program without further changes, it will run and the binding will silently fail. It is the default behavior of a binding in a WPF application.

However, in some applications you **do want to throw exception** if a binding is wrong (in particular, in a unit test project).

To do that, you just need to add this call (I did it in `App.xaml.cs`):

    BindingExceptionThrower.Attach();

Thanks to that single line, every WPF binding error will cause an exception at runtime.
    
![Exception show in Visual Studio](Pictures/XamlParseException.png)