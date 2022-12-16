using System;
using System.IO;
using System.Collections.Generic;

namespace Full_GRASP_And_SOLID.Library;

public class FilePrinter : IPrinter
{  
    public void PrintBuilding(Building building)
    {
        File.WriteAllText("Building.txt", building.imprimirBuilding());

    }


    

}
