using Bytescout.Spreadsheet;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSelenium.Test
{
   
    class demo
    {
        [Test]
        public void testing ()
        {
            Spreadsheet spreadsheet = new Spreadsheet();
            spreadsheet.LoadFromFile(@"C:\Users\yusuf\source\repos\CSharpSelenium\CSharpSelenium\Data\data.xlsx");
            Worksheet s = spreadsheet.Workbook.Worksheets.ByName("Sheet1");
            int row = s.NotEmptyRowMax;
            int col = s.NotEmptyColumnMax;
            Console.WriteLine(  row);
            Console.WriteLine( col);

        }
    }
}
