using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;


namespace ConsoleAppForPractice
{
    [Serializable]
    //creating my own custom exception
    internal class UserAlreadyLoginException : Exception
    {
        //default user defined constructor pointiong to base class constructor
        public UserAlreadyLoginException() : base()
        {
        }

        //constructor with single parameter pointiong to base class constructor
        public UserAlreadyLoginException(string message) : base(message)
        {
        }

        //constructor with 2 parameters inner exception and a message

        public UserAlreadyLoginException(string message, Exception innerException): base(message, innerException)
        {
        }

        //constructor for seilizing

        public UserAlreadyLoginException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

    }
}
