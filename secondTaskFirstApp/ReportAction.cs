using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secondTaskFirstApp
{
    class ReportAction
    {
        public void ReportMessage(string[] arrayOfWords)
        {
            
            string punctuation_marks = "!.?";
            string currentDate = DateTime.Now.ToString("dd.MM.yyyy hh:mm:ss:fff");
            Console.Write(currentDate + " "); // for the first sentence
            int iterator = 0;
            while (iterator < arrayOfWords.Length)
                {
                 char lastSymbol = arrayOfWords[iterator].ToCharArray()[arrayOfWords[iterator].Length - 1];
                    if (!punctuation_marks.Contains(lastSymbol))
                    {
                        Console.Write(arrayOfWords[iterator] + " ");
                    }
                    else
                    {
                        string str = DateTime.Now.ToString("dd.MM.yyyy hh:mm:ss:fff");
                        Console.Write(arrayOfWords[iterator] + "\n");
                        if (iterator != arrayOfWords.Length - 1)
                        {
                            Console.Write(str + " ");
                        }
                    }
                    iterator++;
                }
            }
            
        }
    }



