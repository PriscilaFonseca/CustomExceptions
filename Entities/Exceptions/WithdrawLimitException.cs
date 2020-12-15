using System;

namespace CustomExceptions.Entities.Exceptions
{
    class WithdrawLimitException : ApplicationException
    {
        public WithdrawLimitException(string massage) : base(massage)
        {
        }
    }
}
