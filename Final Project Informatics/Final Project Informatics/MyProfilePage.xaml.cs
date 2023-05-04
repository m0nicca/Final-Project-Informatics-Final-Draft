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
using System.Windows.Shapes;

namespace Final_Project_Informatics
{
    /// <summary>
    /// Interaction logic for MyProfilePage.xaml
    /// </summary>
    public partial class MyProfilePage : Window
    {
        public MyProfilePage()
        {
            InitializeComponent();
        }

        private void PreviousPageButton5_Click(object sender, RoutedEventArgs e)
        {
            HomePage window = new HomePage();
            window.Show();
            this.Close();
        }

        private void UpdateProfileButton_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlInsert = new SqlConnection(@"Data Source=LABSCIFIPC12\LOCALHOST; Initial Catalog=FinalProjectInformatics; Integrated Security=True");

            try
            {

                sqlInsert.Open();

                string queryInsert = "update Users set Username = '" + this.usernametxt.Text + "', [Password] = '" + this.passwordtxt.Password + "' where Email = '" + this.emailtxt.Text + "';";

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

        private void DeleteProfileButton_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlInsert = new SqlConnection(@"Data Source=LABSCIFIPC12\LOCALHOST; Initial Catalog=FinalProjectInformatics; Integrated Security=True");

            try
            {

                sqlInsert.Open();

                string queryInsert = "delete from Users where Email = '" + this.emailtxt.Text + "';";

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

        private void LogoButton5_Click(object sender, RoutedEventArgs e)
        {
            HomePage window = new HomePage();
            window.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LABSCIFIPC12\LOCALHOST; Initial Catalog=FinalProjectInformatics; Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from Users where Username = '" + this.usernametxt.Text + "';", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataAdapter sdr = new SqlDataAdapter(cmd);
            sdr.Fill(dt);
            dataGrid.ItemsSource = dt.DefaultView;
            con.Close();

        }
    }
}
