using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secondTaskFirstApp
{
    class OperationsWithText
    {

       public string[] parseTextToArray(string text)
        {
            string[] arrayOfWords = text.Split(' ');
            string[] arrayOrWordsWithLowerCase = new string[arrayOfWords.Length];
            int iterator = 0;
            while(iterator < arrayOfWords.Length)
            {
                arrayOrWordsWithLowerCase[iterator] = arrayOfWords[iterator].ToLower();
                iterator++;
            }

      
            return arrayOrWordsWithLowerCase;
        }

    }
}
