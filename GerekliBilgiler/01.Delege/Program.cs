using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Delege
{
    delegate void MyDelegate(int sayi1, int sayi2);
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDelegate myDelegate = new MyDelegate(Topla);
            myDelegate += Carp;
            myDelegate.Invoke(5, 10);
            Console.WriteLine("Hello World!");
        }
        static void Topla(int numara1, int numara2)
        {
            Console.WriteLine("Toplam: " + (numara1 + numara2));
        }
        static void Carp(int sayi1, int sayi2)
        {
            Console.WriteLine("Çarpım: " + (sayi1 * sayi2));
        }
    }
}
