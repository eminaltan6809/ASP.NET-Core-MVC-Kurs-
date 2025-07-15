using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PredicateDelegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Predicate<string> predicate = new Predicate<string>(EminiBul);

            var result = predicate.Invoke("Emin");

            List<string> names = new List<string> {"Yavuz", "Ahmet","Ayşe","Emin"};

            names.Find(predicate);
        }

        private static bool EminiBul(string obj)
        {
            return obj == "Emin";
        }
    }
}
