using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WpfBindingErrors;

namespace SampleWpfApplication
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // Start listening for WPF binding error.
            // After that line, a BindingException will be thrown each time
            // a binding error occurs
            BindingExceptionThrower.Attach();
        }
    }
}
