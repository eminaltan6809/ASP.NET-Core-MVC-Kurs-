using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ActionDelege
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action action = new Action(SelamVer);
            action.Invoke();

            //Action<string> action2 = new Action<string>(SelamVer2);
            //action2 += SelamVer3;
            //action2.Invoke("Emin");
            
            Action<string> action2 = new Action<string>(name => 
            {
                Console.WriteLine(name);
            });

            action2.Invoke("emin");
        }

        private static void SelamVer3(string name)
        {
            Console.WriteLine("Selam" + name + "Nasılsın");
        }

        private static void SelamVer2(string name)
        {
            Console.WriteLine("Selam" + name);
        }

        private static void SelamVer()
        {
            Console.WriteLine("Selam Emin");
        }
    }
}
