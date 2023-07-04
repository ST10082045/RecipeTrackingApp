using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeTrackingApp
{
    public class Recipe
    {
        public string Name { get; set; }
        public List<Ingredient> IngredientsList { get; set; }
        public int NumOfIngredients { get; set; }
        public int NumOfSteps { get; set; }
        public List<string> StepsList { get; set; }

        public void RecipeDeclare1(int pNumIngredients)
        {
            IngredientsList = new List<Ingredient>(pNumIngredients);
            NumOfIngredients = pNumIngredients;
        }
        public void RecipeDeclare2(int pNumSteps)
        {
            StepsList = new List<string>(pNumSteps);
            NumOfSteps = pNumSteps;
        }
    }
}
