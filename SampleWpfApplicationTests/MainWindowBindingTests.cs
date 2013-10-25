using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleWpfApplication;
using WpfBindingErrors;
using System.Windows;

namespace UnitTestProject
{
    [TestClass]
    public class MainWindowBindingTests
    {
        [TestMethod]
        public void MainWindows_Constructor_DoesNotThrow()
        {
            AssertDoesNotThrow(() => new MainWindow());
        }

        [TestMethod]
        public void MainWindows_HasNoBindingError()
        {
            // NB: this test must fail !
            // it's the goal of this project: to show that we can raise exceptions

            using( var listener = new BindingErrorListener())
            {
                listener.ErrorCatched += msg => Assert.Fail(msg);

                var win = new MainWindow();
            }            
        }

        static MainWindowBindingTests()
        {
            var dictUri = new Uri("/SampleWpfApplication;component/Resources.xaml", UriKind.Relative);
            var dict = Application.LoadComponent(dictUri) as ResourceDictionary;

            var app = new Application();
            app.Resources.MergedDictionaries.Add(dict);
        }

        static void AssertDoesNotThrow<T>(Func<T> func)
        {
            T value;
            try
            {
                value = func();
            }
            catch(Exception e)
            {
                Assert.Fail(e.Message);
            }
        }
    }
}
