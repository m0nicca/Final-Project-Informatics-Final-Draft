using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
    /// Interaction logic for AllRecipes.xaml
    /// </summary>
    public partial class AllRecipes : Window
    {
        public AllRecipes()
        {
            InitializeComponent();
        }

        private void SaveRecipe1_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlInsert = new SqlConnection(@"Data Source=LABSCIFIPC12\LOCALHOST; Initial Catalog=FinalProjectInformatics; Integrated Security=True");

            try
            {

                sqlInsert.Open();

                string queryInsert = "insert into User_Recipe (Username, RecipeID) values ('" + this.usernametxt1.Text + "', 1);";

                SqlCommand cmd = new SqlCommand(queryInsert, sqlInsert);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Command executed successfully!");

            }

            catch (Exception ex)

            {

                MessageBox.Show(ex.Message);

            }

            finally

            {

                sqlInsert.Close();

            }


        }

        private void SaveRecipe2_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlInsert = new SqlConnection(@"Data Source=LABSCIFIPC12\LOCALHOST; Initial Catalog=FinalProjectInformatics; Integrated Security=True");

            try
            {

                sqlInsert.Open();

                string queryInsert = "insert into User_Recipe (Username, RecipeID) values ('" + this.usernametxt1.Text + "', 2);";

                SqlCommand cmd = new SqlCommand(queryInsert, sqlInsert);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Command executed successfully!");

            }

            catch (Exception ex)

            {

                MessageBox.Show(ex.Message);

            }

            finally

            {

                sqlInsert.Close();

            }


        }

        private void PreviousPageButton1_Click(object sender, RoutedEventArgs e)
        {
            HomePage window = new HomePage();
            window.Show();
            this.Close();
        }

        private void LogoButton1_Click(object sender, RoutedEventArgs e)
        {
            HomePage window = new HomePage();
            window.Show();
            this.Close();
        }
    }

}

