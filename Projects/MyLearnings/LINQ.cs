using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public static class QuerySyntax
    {
        public static void SelectContains()
        {
            IList<string> array = new List<string>()
            {
                "Value abc",
                "def",
                "hfi value",
                "klm",
                "zzy",
                "kk value"
            };
            //find "value" 
            var result = (from qry in array
                          where qry.Contains("value")
                          select qry);
                          
            foreach(var arr in result)
            {
                Console.WriteLine(string.Format("this: {0}", arr.ToString()));
            }
        }

        public static void SelectLamdaSearch()
        {
            IList<string> array = new List<string>()
            {
                "Value abc",
                "def",
                "hfi value",
                "klm",
                "zzy",
                "kk value"
            };

            var result = array.Where(s => s.Contains("value"));
            foreach (var arr in result)
            {
                Console.WriteLine(string.Format("this: {0}", arr.ToString()));
            }

        }

    }
}
