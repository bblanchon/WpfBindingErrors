/**
 * WPF Binding Error Testing
 * Copyright 2013 Benoit Blanchon
 * 
 * This has been inpired by  
 * http://tech.pro/tutorial/940/wpf-snippet-detecting-binding-errors
 */

namespace WpfBindingErrors
{
    public static class BindingExceptionThrower
    {
        static BindingErrorListener errorListener;

        public static void Attach()
        {
            errorListener = new BindingErrorListener();
            errorListener.ErrorCatched += OnErrorCatched;
        }

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

        static void OnErrorCatched(string message)
        {
            throw new BindingException(message);
        }
    }
}
