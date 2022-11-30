using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectCodeLibrary
{
    public class CorrectCodeClass
    {
        public static bool IsCorrectCode(string candidate)
        {
            // int candidateNumbers = Convert.ToInt32(candidate);
            if (candidate == String.Empty)
            {
                return false;
            }
            char[] candidateArray = candidate.ToArray();
            if (candidateArray.Length != 10)
            {
                return false;
            }
            int sum = 0;
            for (int i = 0; i < candidateArray.Length; i++)
            {
                sum += Convert.ToInt32(Char.GetNumericValue(candidateArray[i]));
            }

            int ostOne = sum % 10;
            int ostTwo = sum % 3;

            if (ostOne == 0 && candidateArray[9] == '0')
            {
                return true;
            }

            else if (ostTwo == 0 && candidateArray[9] == '1')
            {
                return true;
            }

            else if(candidateArray[9] == '9')
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
