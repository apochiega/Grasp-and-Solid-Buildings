using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePrinter 
    {
        public static void PrintPrecio(Building building)
        {
            Console.WriteLine($"Building {building.imprimirBuilding()}:");
        }
        
    }
}