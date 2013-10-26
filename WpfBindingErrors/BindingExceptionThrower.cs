/**
 * WPF Binding Error Testing
 * Copyright 2013 Benoit Blanchon
 * 
 * This has been inpired by  
 * http://tech.pro/tutorial/940/wpf-snippet-detecting-binding-errors
 */

using System.Diagnostics;
namespace WpfBindingErrors
{
    /// <summary>
    /// Converts WPF binding error into BindingException
    /// </summary>
    public static class BindingExceptionThrower
    {
        static BindingErrorListener errorListener;

        /// <summary>
        /// Start listening WPF binding error
        /// </summary>
        public static void Attach()
        {
            errorListener = new BindingErrorListener();
            errorListener.ErrorCatched += OnErrorCatched;
        }

        /// <summary>
        /// Stop listening WPF binding error
        /// </summary>
        public static void Detach()
        {
            errorListener.ErrorCatched -= OnErrorCatched;
            errorListener.Dispose();
            errorListener = null;
        }
        
        public static bool IsAttached
        {
            get { return errorListener != null; }
        }

        [DebuggerStepThrough]
        static void OnErrorCatched(string message)
        {
            throw new BindingException(message);
        }
    }
}
