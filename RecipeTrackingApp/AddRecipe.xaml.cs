using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RecipeTrackingApp
{
    /// <summary>
    /// Interaction logic for AddRecipe.xaml
    /// </summary>
    public partial class AddRecipe : Page
    {
        private static double totalCalories;
        public static int numIngredients;
        public static int numSteps;
        public static int numbVar = 2;
        public static int numbVars = 2;
        RecipeList = new List<Recipe>();
        //Creating a Recipe Object which will then be Added to the RecipeList
        Recipe recipeObj = new Recipe();
        public AddRecipe()
        {
            InitializeComponent();
                          
        }

        private void BtnHomeClick(object sender, RoutedEventArgs e)
        {
            //NavigationService.GoBack();
            MainWindow page = new MainWindow();
            page.Show();
            //AddRecipe.Close();
        }

        private void BtnIngContinueClick(object sender, RoutedEventArgs e)
        {
            totalCalories = 0;                
            numIngredients = Convert.ToInt32(txtNumIngredients.Text);
            recipeObj.RecipeDeclare1(numIngredients);
            recipeObj.Name = txtName.Text;

            txtIngNumb.Text = "1";
           
        }

        private void BtnEnterIngClick(object sender, RoutedEventArgs e)
        {
            
            //Filling the Ingredients List with user input
                //Creating an Ingredient Object which will then be Added to the IngredientsList
                Ingredient ingrdientObj = new Ingredient();
                //Name
                ingrdientObj.Name = txtIngName.Text;
                //Quantity
                ingrdientObj.Quantity = Convert.ToInt32(txtIngQuantity.Text);
                ingrdientObj.OriginalQuantity = ingrdientObj.Quantity;
                //Measurement
                ingrdientObj.Measurement = txtIngMeasurement.Text;
                //Calories
                ingrdientObj.NumCalories = Convert.ToInt32(txtIngCalories.Text);
                ingrdientObj.OriginalCalories = ingrdientObj.NumCalories;
                totalCalories = totalCalories + ingrdientObj.NumCalories;
                 //MyDataPort.DataIn(totalCalories);
                //Food Group
                ingrdientObj.FoodGroup = txtIngFoodGrp.Text;
                //Adding Object To List
                recipeObj.IngredientsList.Add(ingrdientObj);
            numbVar++;
            if (numbVar > numIngredients)
            {
                txtErrorIng.Text = "All Ingredients Added.";
                txtIngName.IsEnabled = false;
                txtIngQuantity.IsEnabled = false;
                txtIngMeasurement.IsEnabled = false;
                txtIngCalories.IsEnabled = false;
                txtIngFoodGrp.IsEnabled = false;
                btnEnterIng.IsEnabled=false;
            }
            else
            {
                txtErrorIng.Text = "";
                txtIngNumb.Text = numbVar.ToString();
                txtIngName.Text = "";
                txtIngQuantity.Text = "";
                txtIngMeasurement.Text = "";
                txtIngCalories.Text = "";
                txtIngFoodGrp.Text = "";
            }
                    
        }

        private void BtnStepsContinueClick(object sender, RoutedEventArgs e)
        {
            
             numSteps = Convert.ToInt32(txtNumSteps);
        }

        private void BtnEnterStepsClick(object sender, RoutedEventArgs e)
        {
          
            recipeObj.StepsList.Add(txtStep.Text);
            numbVars++;
            if (numbVars > numIngredients)
            {
                txtErrorSteps.Text = "All Steps Added";
                txtStep.IsEnabled = false;
                btnEnterSteps.IsEnabled = false;
            }
            else
            {
                txtErrorSteps.Text = "";
                txtStepsTnumber.Text = numbVars.ToString();
                txtStep.Text = "";
            }
        }

        private void BtnAddRecipeClick(object sender, RoutedEventArgs e)
        {
            RecipeList = new List<Recipe>();
            //Adding RecipeObj to RecipeList
            ((App)Application.Current).RecipeList.Add(recipeObj);
        }
    }
}
