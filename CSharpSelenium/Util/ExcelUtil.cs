using Bytescout.Spreadsheet;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSelenium.Util
{
    [TestFixture]
    public class ExcelUtil
    {
        public String getEcxelData(String SheetName,int row,int colomn)
        {

            Spreadsheet spreadsheet = new Spreadsheet();
            spreadsheet.LoadFromFile(@"C:\Users\yusuf\source\repos\CSharpSelenium\CSharpSelenium\Data\data.xlsx");
            Worksheet s = spreadsheet.Workbook.Worksheets.ByName(SheetName);
            String data=s.Cell(row,colomn).ToString();

            return data;
        }
        public static Object[,] getEcxelAllData(String SheetName)
        {

            Spreadsheet spreadsheet = new Spreadsheet();
            spreadsheet.LoadFromFile(@"C:\Users\yusuf\source\repos\CSharpSelenium\CSharpSelenium\Data\data.xlsx");
            Worksheet s = spreadsheet.Workbook.Worksheets.ByName(SheetName);
            int row = s.NotEmptyRowMax;
            int col=s.NotEmptyColumnMax;
            Object[,]arr=new object[row+2,col+2];
            for(int i=0;i<=row+1;i++)
            {
                for(int j=0;j<=col+1;j++)
                {
                    String data = s.Cell(i, j).ToString();
                    arr[i,j]=data;
                }
            }

           

            return arr;
        }
    }
}
