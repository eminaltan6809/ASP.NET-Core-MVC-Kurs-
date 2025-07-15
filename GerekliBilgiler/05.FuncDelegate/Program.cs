using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.FuncDelegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> isimler = new List<string>() {"Yavuz","Mahmut","Emin"};

            Func<string,bool> func = new Func<string,bool> (Ayibul);

            var aIcerenIsimler = isimler.Where(func);
        }

        private static bool Ayibul(string arg)
        {
            return arg.Contains("a");
        }
    }
}
