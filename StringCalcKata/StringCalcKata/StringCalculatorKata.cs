using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalcKata
{
    public class StringCalculatorKata
    {
        public static int Add(string numbers)
        {
            if (String.IsNullOrEmpty(numbers)) return 0;

            string[] SplitedNumbers;
            if (numbers.StartsWith("//"))
            {

                // "// [delimiter] \n [numbers...]"
                numbers = numbers.Substring(2);

                // "[delimiter] \n [numbers...]"   
                string[] SplitedString = numbers.Split('\n');

                //[delimiter]
                char separator = char.Parse(SplitedString[0]);

                //"[numbers...]"   
                numbers = SplitedString[1];

                //["num1" ,"num2",...]   
                SplitedNumbers = numbers.Split(separator);

            }

            else
            {
                char[] separators = { ',', '\n' };
                SplitedNumbers = numbers.Split(separators);

            }


            return SplitedNumbers.Select(num => int.Parse(num)).Sum();
        



        }
    }
}
