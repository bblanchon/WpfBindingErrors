/**
 * WPF Binding Error Testing
 * Copyright 2013 Benoit Blanchon
 * 
 * This has been inpired by  
 * http://tech.pro/tutorial/940/wpf-snippet-detecting-binding-errors
 */

using System;

namespace WpfBindingErrors
{
    [Serializable]
    public class BindingException : Exception
    {
        public BindingException(string message) 
            : base(message)
        {

        }
    }
}
