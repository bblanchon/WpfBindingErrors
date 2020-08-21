using System;
using SampleWpfApplication;
using WpfBindingErrors;
using System.Windows;
using Xunit;

namespace SampleWpfApplicationTests
{
    public class MainWindowBindingTests
    {
        [StaFact]
        public void MainWindow_Constructor_DoesNotThrow()
        {
            new MainWindow();
        }

        [StaFact]
        public void MainWindow_HasNoBindingError()
        {
            // NB: this test must fail !
            // it's the goal of this project: to show that we can
            // detect binding errors in a unit test

            using( var listener = new BindingErrorListener())
            {
                listener.ErrorCatched += msg => throw new Exception(msg);

                new MainWindow();
            }            
        }

        static MainWindowBindingTests()
        {
            // Load the resources required to create MainWindow
            // (in this case, we need ViewModelLocator)
            // The trick is to move resources into a dedicated file, instead of App.xaml           

            var resourcesUri = new Uri("/SampleWpfApplication;component/Resources.xaml", UriKind.Relative);
            var resources = Application.LoadComponent(resourcesUri) as ResourceDictionary;

            var app = new Application();
            app.Resources.MergedDictionaries.Add(resources);
        }
    }
}
