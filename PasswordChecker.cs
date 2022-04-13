using System;

namespace PasswordChecker
{
    class Program
    {
        public static void Main(string[] args)
        {

            //Define variables
            int minLength = 8;
            string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowercase = "abcdefghijklmnopqrstuvwxyz";
            string digits = "0123456789";
            string specialChars = "!?£$%^&*:;@'~#{}[]/-_=+\"\"";

            //User input
            Console.WriteLine("Please enter a password: ");
            string passwordNew = Console.ReadLine();

            //Check password vs above variables to determine the score.
            int score = 0;
            if ((passwordNew == "1234") || (passwordNew == "password"))
            {
                score = 0;
            }
            else
            {
                if (passwordNew.Length >= minLength)
                {
                    score++;
                }
                if (Tools.Contains(passwordNew, uppercase))
                {
                    score++;
                }
                if (Tools.Contains(passwordNew, lowercase))
                {
                    score++;
                }
                if (Tools.Contains(passwordNew, digits))
                {
                    score++;
                }
                if (Tools.Contains(passwordNew, specialChars))
                {
                    score++;
                }

            }


            //Switch statement to return the users score.
            switch (score)
            {
                case 5:
                    Console.WriteLine("5. Extremely Strong");
                    break;

                case 4:
                    Console.WriteLine("4: Extremely Strong");
                    break;

                case 3:
                    Console.WriteLine("3: Strong");
                    break;

                case 2:
                    Console.WriteLine("2: Medium");
                    break;

                case 1:
                    Console.WriteLine("1: Weak");
                    break;

                default:
                    Console.WriteLine("Doesn't meet minimum requirements.");
                    break;
            }
        }
    }
}