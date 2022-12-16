using System;
using System.IO;
using System.Collections.Generic;

namespace Full_GRASP_And_SOLID.Library;

public class FilePrinter2 : IPrinter
{  
    public void PrintBuilding(Building building)
    {
        File.WriteAllText("Building2.txt", building.imprimirBuilding());

    }


    

}
