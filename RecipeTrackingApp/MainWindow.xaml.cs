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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnClickAddRecipe(object sender, RoutedEventArgs e)
        {
            AddRecipe page = new AddRecipe();
            _mainFrame.NavigationService.Navigate(page);
          // _mainFrame.Navigate(new Uri("AddRecipe.xaml", UriKind.Relative));
        }

        private void BtnClickDisplayRecipes(object sender, RoutedEventArgs e)
        {
            // _mainFrame.Content = new DisplayRecipes();
            DisplayRecipes page = new DisplayRecipes();
            _mainFrame.NavigationService.Navigate(page);
        }

        private void BtnClickSpecificRecipe(object sender, RoutedEventArgs e)
        {
            // _mainFrame.Content = new SpecificRecipe();
            SpecificRecipe page = new SpecificRecipe();
            _mainFrame.NavigationService.Navigate(page);
        }
    }
}
