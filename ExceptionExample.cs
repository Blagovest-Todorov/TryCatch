using System;

namespace _02.ExceptionExample
{
    class ExceptionExample
    {
        public static void CauseFormatException()
        {
            string s = "an Invalid number";
            Int32.Parse(s); //We try here to Parse String to number-this can not happen -> throws exception error
        }
        static void Main()
        {
            try
            {
                CauseFormatException(); //we call the method  here
            }
            catch (FormatException fe)
            {

                Console.Error.WriteLine("Exception: {0} \n{1}", fe.Message, fe.StackTrace); //we trhow error message
            }
        }
    }
}
