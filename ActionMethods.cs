using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Test
{
   public class ActionMethods
    {
        public void showDate()
        {
            DateTime dateTime = DateTime.UtcNow.Date;
            Console.WriteLine(dateTime.ToString("dd/MM/yyyy"));
            Console.WriteLine("Enter any key to Return");
            Console.ReadKey();
        }

        public void showTime()
        {
            Console.WriteLine(string.Format("{0:HH:mm:ss tt}", DateTime.Now));
            Console.WriteLine("Enter any key to Return");
            Console.ReadKey();
        }

        public void countCapitalLetters()
        {
            int amountOfCapitalLetters;
            Console.WriteLine("please enter a sentence:");
            string inputFromUser = Console.ReadLine();
            amountOfCapitalLetters = checkAmountOfCapitalLettersInString(inputFromUser);
            Console.WriteLine("there are {0} capital letters in your sentence", amountOfCapitalLetters);
            Console.WriteLine("Enter any key to Return");
            Console.ReadKey();
        }

        private int checkAmountOfCapitalLettersInString(string i_inputString)
        {
            int o_AmountOfCapitalLetter = 0;
            int i;
            for (i = 0; i < i_inputString.Length; i++)
            {
                char specipicCharInString = i_inputString[i];
                if (char.IsUpper(specipicCharInString))
                {
                    o_AmountOfCapitalLetter++;
                }
            }

           

            return o_AmountOfCapitalLetter;
        }

        public void showVersion()
        {
            Console.WriteLine("Version: 18.2.4.0");
            Console.WriteLine("Enter any key to Return");
            Console.ReadKey();
        }
    }
}
