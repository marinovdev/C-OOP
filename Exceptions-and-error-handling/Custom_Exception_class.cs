using System;

namespace Custom_Exception_class
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
            var register = new Register("userPatrick12345");
            }
            catch (InvalidUserInputException ex)
            {
                Console.WriteLine(ex.Error);
            }
        }
    }

    public class InvalidUserInputException : Exception
    {
        public InvalidUserInputException()
        {

        }

        public InvalidUserInputException(string message, string userInput)
            : base(message)
        {
            UserInput = userInput;
        }

        public string UserInput { get; set; }

        public string Error { get => base.Message + UserInput; }
    }

    public class Register
    {
        public string UserName { get; set; }

        public Register(string userName)
        {
            if(userName.Length <= 10)
            {

            UserName = userName;
            }
            else
            {
                throw new InvalidUserInputException("Must not be bigger than 10 letters", UserName);
            }
        }
    }
}
