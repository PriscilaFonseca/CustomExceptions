using System;

namespace CustomExceptions.Entities.Exceptions
{
    class LowBalanceException : ApplicationException
    {
        public LowBalanceException(string message) : base(message)
        {
        }
    }
}
