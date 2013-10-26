using System;

namespace SampleWpfApplication
{
    /// <summary>
    /// Sample view model for MainWindow.
    /// </summary>
    class MainWindowViewModel
    {
        /// <summary>
        /// Normal property, will not generate a binding error
        /// </summary>
        public string GoodBinding { get { return "Hello World!"; } }


        /// <summary>
        /// Wrong property, will generate a binding error.        
        /// </summary>        
        /* public string BadBinding { get { throw new Exception("Hi !"); } } */

        // Also works when a property getter throws and Exception.
        // You can try by uncommenting BadBinding definition.
    }
}
