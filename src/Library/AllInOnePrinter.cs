//---------------------------------------------------------------------------------
// <copyright file="AllInOnePrinter.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//---------------------------------------------------------------------------------
using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
    public enum Destination
    {
        Console,
        File
    }

    public class AllInOnePrinter
    {
        public void PrintPrecio(Building building, Destination destination)
        {
            if (destination == Destination.Console)
            {
                Console.WriteLine(building.imprimirBuilding());
            }
            else
            {
                File.WriteAllText("Building.txt", building.imprimirBuilding());
            }
        }
    }
}