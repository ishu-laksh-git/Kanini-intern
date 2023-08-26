using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question5App
{
    internal class q5
    {
        private string cardNumber;
        public q5()
        {
            GetCardNumber();
            ValidateCardNumber();
        }
        public void GetCardNumber()
        {
            Console.WriteLine("PLease enter your card number: ");
            cardNumber = Console.ReadLine();
        }
        public void ValidateCardNumber()
        {
            int sum = 0;
            int[] evenPositionArray = new int[8];
            int[] oddPositionArray = new int[8];
            char[] stringArray = cardNumber.ToCharArray();
            Array.Reverse(stringArray);
            for (int i = 0; i < stringArray.Length; i++)
            {
                if (i % 2 == 0)
                {
                    evenPositionArray.Append(Convert.ToInt32(stringArray[i]) * 2);
                }
                else
                {
                    oddPositionArray.Append(Convert.ToInt32(stringArray[i]));

                }
            }
            for (int i = 0; i < evenPositionArray.Length; i++)
            {
                if (Convert.ToString(evenPositionArray[i]).Length == 2)
                {
                    evenPositionArray[i] = DoubleDigit(evenPositionArray[i]);
                }
            }
            sum = evenPositionArray.Sum() + oddPositionArray.Sum();
            if (sum % 10 == 0)
            {
                Console.WriteLine("Valid card!");
            }
            else
            {
                Console.WriteLine("Card invalid....");
            }
        }
        public int DoubleDigit(int number)
        {
            return number - 9;
        }
    }
}

  