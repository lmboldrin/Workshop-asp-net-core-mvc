using System;

namespace SalesWebMVC.Services.Exceptions
{
    public class BdConcurrencyException : ApplicationException
    {
        public BdConcurrencyException(string message) : base(message)
        {

        }

    }
}
