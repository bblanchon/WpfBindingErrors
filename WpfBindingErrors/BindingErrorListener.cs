/**
 * WPF Binding Error Testing
 * Copyright 2013 Benoit Blanchon
 * 
 * This has been inpired by  
 * http://tech.pro/tutorial/940/wpf-snippet-detecting-binding-errors
 */

using System;
using System.Diagnostics;

namespace WpfBindingErrors
{
    /// <summary>
    /// Raises an event each time a WPF Binding error occurs.
    /// </summary>
    public sealed class BindingErrorListener : IDisposable
    {      
        readonly TraceListener traceListener;

        static BindingErrorListener()
        {
            PresentationTraceSources.Refresh();
        }

        public BindingErrorListener()
        {
            traceListener = new TraceListener();
            PresentationTraceSources.DataBindingSource.Switch.Level = SourceLevels.Error;
            PresentationTraceSources.DataBindingSource.Listeners.Add(traceListener);
        }

        public void Dispose()
        {            
            PresentationTraceSources.DataBindingSource.Listeners.Remove(traceListener);
            traceListener.Dispose();
        }      

        public event Action<string> ErrorCatched
        {
            add { traceListener.TraceCatched += value; }
            remove { traceListener.TraceCatched -= value; }
        }
    }
}
