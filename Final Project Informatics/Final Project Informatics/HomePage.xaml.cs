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
using System.Windows.Shapes;

namespace Final_Project_Informatics
{
    /// <summary>
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : Window
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void RecipesPageButton_Click(object sender, RoutedEventArgs e)
        {
            AllRecipes window = new AllRecipes();
            window.Show();
            this.Close();

        }

        private void HealthArticlesPageButton_Click(object sender, RoutedEventArgs e)
        {
            HealthArticlesPage window = new HealthArticlesPage();
            window.Show();
            this.Close();

        }

        private void SavedRecipesPageButton_Click(object sender, RoutedEventArgs e)
        {
            SavedRecipesPage window = new SavedRecipesPage();
            window.Show();
            this.Close();
        }

        private void SavedArticlesPageButton_Click(object sender, RoutedEventArgs e)
        {
            SavedArticlesPage window = new SavedArticlesPage();
            window.Show();
            this.Close();

        }

        private void MyProfilePageButton_Click(object sender, RoutedEventArgs e)
        {
            MyProfilePage window = new MyProfilePage();
            window.Show();
            this.Close();

        }
    }
}
