using System;

namespace SampleWpfApplication
{
    class MainWindowViewModel
    {
        public string GoodBinding { get { return "Hello World!"; } }
        // public string BadBinding { get { throw new Exception("Hi !"); } } // Also works when a property throws
    }
}
