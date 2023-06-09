//-------------------------------------------------------------------------------
// <copyright file="Step.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------

namespace Full_GRASP_And_SOLID.Library
{
    public class Step
    {
        public Product Input { get; set; }
        public double Quantity { get; set; }
        public int Time { get; set; }
        public Equipment Equipment { get; set; }
        // Agrego precio de cada paso
        public double Cost {get ; set ;}
        public Step(Product input, double quantity, Equipment equipment, int time)
        {
            this.Quantity = quantity;
            this.Input = input;
            this.Time = time;
            this.Equipment = equipment;
            this.Cost = (equipment.HourlyCost * time) + (input.UnitCost * quantity);
        }
    }
}