using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Game
{
    public class FizzBuzzBoard
    {
        public string GetWordForNumber(int number)
        {
            if (number % 3 == 0)
            {
                return "Fizz";
            }
            else if (number % 5 == 0)
            {
                return "Buzz";
            }
            else
            {
                return "";
            }


            //return number % 3 == 0 ? "Fizz" : "Buzz";
        }
    }
}
