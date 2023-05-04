using System;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Final_Project_Informatics
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

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source=LABSCIFIPC12\LOCALHOST; Initial Catalog=FinalProjectInformatics; Integrated Security=True");

            try
            {

                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
                string query = "SELECT COUNT(1) FROM Users Where Username=@Username and Password=@Password";
                SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@Username", usernametxt.Text);
                sqlCmd.Parameters.AddWithValue("@Password", passwordtxt.Password);

                int count = Convert.ToInt32(sqlCmd.ExecuteScalar());
                if (count == 1)
                {
                    HomePage window = new HomePage();
                    window.Show();
                    this.Close();

                }
                else if (usernametxt.Text != null || passwordtxt.Password != null)
                {

                    HomePage pl = new HomePage();
                    MessageBox.Show("Please enter valid information!");

                }
                else
                {

                    MessageBox.Show("password is not correct");
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
        }

        private void SignUpPageButton_Click(object sender, RoutedEventArgs e)
        {
            SignUpPage window = new SignUpPage();
            window.Show();
            this.Close();
        }
    }
}
