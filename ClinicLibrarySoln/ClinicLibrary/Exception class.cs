using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorModelLibrary
{
    public class MinusValueNotAcceptedException : Exception
    {
        string message;
        public MinusValueNotAcceptedException()
        {
            message = "minus values cannot be accepted for these fields";
        }
        public override string Message => message;
    }
    public class MinusValueAndZeroNotAcceptedException : Exception
    {
        string message;
        public MinusValueAndZeroNotAcceptedException()
        {
            message = "minus values or zeros cannot be accepted for these 				fields";
        }
        public override string Message => message;
    }
    public class EmptyStringException : Exception
    {
        string message;
        public EmptyStringException()
        {
            message = "Name cannot be empty or null";
        }
        public override string Message => message;
    }
    public class NotAnIntegerException : Exception
    {
        string message;
        public NotAnIntegerException()
        {
            message = "Integer can only accepted";
        }
        public override string Message => message;
    }
    public class InputRangeException : Exception
    {
        string message;
        public InputRangeException()
        {
            message = "range should be 1 to 10";
        }
        public override string Message => message;
    }
}

