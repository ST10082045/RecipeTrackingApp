using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeTrackingApp
{
    internal class Ingredient
    {
        public string Name { get; set; }
        public double Quantity { get; set; }
        public string Measurement { get; set; }
        public double NumCalories { get; set; }
        public string FoodGroup { get; set; }
        public double OriginalQuantity { get; set; }
        public double OriginalCalories { get; set; }
    }
}
