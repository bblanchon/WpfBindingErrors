/**
 * WPF Binding Error Testing
 * Copyright 2013 Benoit Blanchon
 * 
 * This has been inpired by  
 * http://tech.pro/tutorial/940/wpf-snippet-detecting-binding-errors
 */

using System;
using System.Diagnostics;
using System.Text;

namespace WpfBindingErrors
{
    /// <summary>
    /// A TraceListener that raise an event each time a trace is written
    /// </summary>
    sealed class ObservableTraceListener : DefaultTraceListener
    {
        StringBuilder buffer = new StringBuilder();

        public override void Write(string message)
        {
            buffer.Append(message);
        }

        [DebuggerStepThrough]
        public override void WriteLine(string message)
        {
            buffer.Append(message);

            if (TraceCatched != null)
            {
                TraceCatched(buffer.ToString());
            }

            buffer.Clear();
        }

        public event Action<string> TraceCatched;
    }
}
