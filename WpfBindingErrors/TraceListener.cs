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
    sealed class TraceListener : DefaultTraceListener
    {
        StringBuilder buffer = new StringBuilder();

        public override void Write(string message)
        {
            buffer.Append(message);
        }

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
