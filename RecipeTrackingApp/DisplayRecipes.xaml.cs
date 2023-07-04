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
    /// Interaction logic for DisplayRecipes.xaml
    /// </summary>
    public partial class DisplayRecipes : Page
    {
        public DisplayRecipes()
        {
            InitializeComponent();
            Recipe TempRec = new Recipe();
            int recipeID;
            //Sorting the RecipeList Alphabetically
            //
            for (int j = 0; j <= RecipeList.Count - 2; j++)
            {
                for (int i = 0; i <= RecipeList.Count - 2; i++)
                {
                    if (String.Compare(RecipeList[i + 1].Name, RecipeList[i].Name) < 0)
                    {
                        TempRec = RecipeList[i + 1];
                        RecipeList[i + 1] = RecipeList[i];
                        RecipeList[i] = TempRec;
                    }
                }
            }

            for (int i = 0; i < RecipeList.Count; i++)
            {
                txtBoc.Text= txtBoc.Text + ((i + 1) + " - " + RecipeList[i].Name);
            }
            //
        }
    }
}
