using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace al_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Komp k = new Komp();
            k.LoadZPU();
            k.Print('*');
            Console.ReadLine();
        }
    }
}
