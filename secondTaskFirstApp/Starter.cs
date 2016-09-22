using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secondTaskFirstApp
{
    class Starter
    {
        public void start()
        {
            InformationRecieverFromConsole irfc = new InformationRecieverFromConsole();
            String text = irfc.enterText();
           
            OperationsWithText op = new OperationsWithText();
            String[] arrayOfWords = op.parseTextToArray(text);

            ReportAction report = new ReportAction();
            report.ReportMessage(arrayOfWords);
            
        }
    }
}
