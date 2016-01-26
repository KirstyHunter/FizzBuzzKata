using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public string Calculate(int p)
        {
            bool fizz = p % 3 == 0;
            bool buzz = p % 5 == 0;

            if (fizz && buzz)
            {
                return "FizzBuzz";
            }
            else if(fizz)
            {
                return "Fizz";
            }
            else if(buzz)
            {
                return "Buzz";
            }
            return p.ToString();
        }
    }
}
