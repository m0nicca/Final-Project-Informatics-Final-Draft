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
    /// Interaction logic for SignUpPage.xaml
    /// </summary>
    public partial class SignUpPage : Window
    {
        public SignUpPage()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlInsert = new SqlConnection(@"Data Source=LABSCIFIPC12\LOCALHOST; Initial Catalog=FinalProjectInformatics; Integrated Security=True");

            try
            {

                sqlInsert.Open();

                string queryInsert = "insert into Users (Username, Password, Email) values ('" + this.usernametxt.Text + "', '" + this.passwordtxt.Password + "', '" + this.emailtxt.Text + "');";

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


            MainWindow window = new MainWindow();
            window.Show();
            this.Close();

        }

        private void LogInPageButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }
    }
}
