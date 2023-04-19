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
            // Al agregar un paso, agrego el costo de ese paso al total de la receta.
            this.FinalCost = this.FinalCost + step.Cost;
        }
        public void RemoveStep(Step step)
        {
            this.steps.Remove(step);
            // Al quitar un paso, resto el costo de ese paso del total de la receta.
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
        // Este método es básicamente un get del atributo FinalCost.
        public double GetProductionCost()
        {
            return this.FinalCost;
        }
    }
}
/*
Otra alternativa para el método GetProductionCost() podría ser esta.
En vez de ir construyendo el FinalCost al agregar o quitar pasos de la receta,
puedo sumar el costo de cada paso una vez esté finalizada la receta.

        public double GetProductionCost()
        {
            FinalCost = 0;
            foreach (Step step in this.steps)
            {
                FinalCost = step.Cost;
            }
            return FinalCost;
        }
*/