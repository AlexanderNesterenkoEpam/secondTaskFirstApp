using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secondTaskFirstApp
{
    class InformationRecieverFromConsole
    {
        public string text { get; private set; }

        public string enterText()
        {
            string currentText;
            do
            {
                Console.WriteLine("Enter text: ");
                currentText = Console.ReadLine();

            } while (String.IsNullOrWhiteSpace(currentText));
             
            this.text = currentText;

            return text;
        }
    }
}
