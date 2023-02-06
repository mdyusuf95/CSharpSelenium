using CSharpSelenium.Util;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSelenium.Test
{
    [TestFixture]
     class datadrivertest
    {
        [Test]
        public void tstdata ()
        {
            ExcelUtil excel = new ExcelUtil();

            for(int i = 0; i <8; i++)
            {
                
                    String data = excel.getEcxelData("Sheet1",i ,1);
                    Console.WriteLine(data);
                
            }
           
        
        }
        [Test]
        public void tstrow()
        {
            //ExcelUtil excel = new ExcelUtil();
            object[,] s = ExcelUtil.getEcxelAllData("Sheet1");
            foreach(object o in s)
            {
                Console.WriteLine(o);
            }


        }
        //[Test,TestCaseSource(typeof(ExcelUtil), "getEcxelAllData")]
        //public void testing4(Object arr)
        //{
            
        
               
        //}
    }
}
