//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;


namespace Full_GRASP_And_SOLID.Library
{
    public class Building : IPrintable
    {
        private ArrayList tasks = new ArrayList();

        public Building(string name)
        {
            this.Description = name;
        }

        public string Description { get; set; }

        public void AddTask(Task task)
        {
            this.tasks.Add(task);
        }

        public void RemoveTask(Task task)
        {
            this.tasks.Remove(task);
        }

        public string imprimirBuilding()
        {
            string PrintBuilding = "";
            PrintBuilding += $"Edificio {this.Description}: \n";
            foreach (Task task in this.tasks)
            {
                PrintBuilding += $"{task.Quantity} de '{task.Material.Description}' " +
                $"usando '{task.Equipment.Description}' durante {task.Time} \n";
            }
            PrintBuilding += $"El costo de la construcción es de: {this.GetProductionCost()} \n";
            
            return PrintBuilding;
        }

        public double GetProductionCost()
        {
            double precioFinal = 0;
            
            foreach (Task task in this.tasks)
            
            {
                precioFinal += (task.Material.UnitCost * task.Quantity) + (task.Equipment.HourlyCost * task.Time);
            }
            
            
            return precioFinal;
        }
    }
}