using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePrinter : IPrinter
    {
        public void Print(IPrintable printable)
        {
            Console.WriteLine(printable.imprimirBuilding());
        }
        
    }
}