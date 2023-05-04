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
    /// Interaction logic for SavedArticlesPage.xaml
    /// </summary>
    public partial class SavedArticlesPage : Window
    {
        public SavedArticlesPage()
        {
            InitializeComponent();
        }

        private void PreviousPageButton4_Click(object sender, RoutedEventArgs e)
        {
            HomePage window = new HomePage();
            window.Show();
            this.Close();
        }

        private void LogoButton4_Click(object sender, RoutedEventArgs e)
        {
            HomePage window = new HomePage();
            window.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LABSCIFIPC12\LOCALHOST; Initial Catalog=FinalProjectInformatics; Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select User_Article.Username, Articles.ArticleName from User_Article inner join Articles on Articles.ArticleID = User_Article.ArticleID where Username = '" + this.usernametxt.Text + "'; ", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataAdapter sdr = new SqlDataAdapter(cmd);
            sdr.Fill(dt);
            dataGrid.ItemsSource = dt.DefaultView;
            con.Close();
        }
    }
}
