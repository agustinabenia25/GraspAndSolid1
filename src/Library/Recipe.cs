//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class Recipe
    {
        private ArrayList steps = new ArrayList();
        public Product FinalProduct { get; set; }
        // Agrego precio final
        public double FinalCost {get ; set ;}
        public void AddStep(Step step)
        {
            this.steps.Add(step);
            this.FinalCost = this.FinalCost + step.Cost;

        }
        public void RemoveStep(Step step)
        {
            this.steps.Remove(step);
            this.FinalCost = this.FinalCost - step.Cost;
        }
        public void PrintRecipe()
        {
            Console.WriteLine($"Receta de {this.FinalProduct.Description}:\n");
            foreach (Step step in this.steps)
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}\n");
            }
        }
        public double GetProductionCost()
        {
            return this.FinalCost;
        }
    }
}