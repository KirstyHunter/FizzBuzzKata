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
            if(p == 3)
            {
                return "Fizz";
            }
            return p.ToString();
        }
    }
}
