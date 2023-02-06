using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSelenium.Data
{
    public  class TestData
    {
        public static Object[,]  data()

        {

            Object [,] ar = new object[2,2];
            ar[0, 0] = "varuntrades";
            ar[0, 1] = "varuntrades@gg.com";

            ar[1, 0] = "maja fundation";
            ar[1, 1] = "majak@kkom.com";






            return ar ;
        
        
        }
    }
}
