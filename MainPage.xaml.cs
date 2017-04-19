using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace DigitalHealthSubham
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

    //    public DataFetch()
    //    {
    //        using (DbConnection connection = new SqlConnection(SQLConnectionString))
    //        {
    //            // Formulate the command.
    //            SqlCommand command = new C.SqlCommand();
    //            command.Connection = connection;

    //            // Specify the query to be executed.
    //            command.CommandType = D.CommandType.Text;
    //            command.CommandText = @"
    //                SELECT TOP 9 CustomerID, NameStyle, Title, FirstName, LastName
    //                FROM SalesLT.Customer;  -- In AdventureWorksLT database.
    //                ";
    //            // Open a connection to database.
    //            connection.Open();

    //            // Read data returned for the query.
    //            SqlDataReader reader = command.ExecuteReader();
    //            while (reader.Read())
    //            {
    //                Console.WriteLine("Values:  {0}, {1}, {2}, {3}, {4}",
    //                    reader[0], reader[1], reader[2], reader[3], reader[4]);
    //            }
    //        }
    //        Console.WriteLine("View the results here, then press any key to finish...");
    //        Console.ReadKey(true);
    //    }
    //    //----------------------------------------------------------------------------------

    //    static
    //}

        private void list_city_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string[] jalandharHosp = { "Tagore Hospital", "Satyam Hospital","Capital Hospital","Johal Multi Speiality Hospital"};
            string[] chandHosp = { "Chaitanya Hospital", "Indus Hospital", "Omni Hospital", "Inscol Hospital" };
            string[] ludHosp = { "Fortes Hospital", "Bawa Hospital" , "Christian Hospital", "Dayanand Medical Hospital" };


            if(list_city.SelectedIndex==0)
            {
                list_hosp.Items.Clear();
                for(int i=0;i<jalandharHosp.Length;i++)
                {
                    list_hosp.Items.Add(jalandharHosp[i]);
                }
            }
            if (list_city.SelectedIndex == 1)
            {
                list_hosp.Items.Clear();
                for (int i = 0; i < chandHosp.Length; i++)
                {
                    list_hosp.Items.Add(chandHosp[i]);
                }
            }
            if (list_city.SelectedIndex == 2)
            {
                list_hosp.Items.Clear();
                for (int i = 0; i < ludHosp.Length; i++)
                {
                    list_hosp.Items.Add(ludHosp[i]);
                }
            }
        }

        private void ConnectWebServcie()
        {
            HttpClient httpClient = new HttpClient();
        }
        private void list_hosp_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Back_1_Click(object sender, RoutedEventArgs e)
        {
            //this.Frame.Navigate(typeof(UserDetails));
        }
    }
}
