using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
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

namespace WpfApp8
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Car> list = new List<Car>();
            Car c1 = new Car("1234567", 2, true, 100000, "Red", new DateTime(2022, 1, 7), 0);
            Car c2 = new Car("3472839", 5, true, 85000.50, "Green", new DateTime(2000, 10, 16), 1);
            Car c3 = new Car("3782657", 10, false, 50000.90, "White", new DateTime(1987, 7, 1), 2);
            Car c4 = new Car("3482947", 4, false, 75000, "Black", new DateTime(2023, 10, 26), 5);
            Car c5 = new Car("4729572", 2, true, 2000000, "Pink", new DateTime(2025, 1, 1), 0);
            Car c6 = new Car("6543210", 7, false, 65000, "Silver", new DateTime(2018, 11, 30), 3);
            Car c7 = new Car("1673834", 2, true, 450000, "Yellow", new DateTime(2024, 3, 15), 0);
            Car c8 = new Car("4755267", 4, false, 32000.75, "Gray", new DateTime(2010, 8, 1), 4);
            Car c9 = new Car("7473840", 5, true, 99999.99, "Dark Blue", new DateTime(2022, 12, 22), 2);
            Car c10 = new Car("8191928", 5, true, 545000, "Purple", new DateTime(1900, 9, 19), 0);
            list.Add(c1);
            list.Add(c2);
            list.Add(c3);
            list.Add(c4);
            list.Add(c5);
            list.Add(c6);
            list.Add(c7);
            list.Add(c8);
            list.Add(c9);
            list.Add(c10);
            spCarId.ItemsSource = list;
            mySp.Visibility = Visibility.Collapsed;
            DetailsName.Visibility = Visibility.Collapsed;


        }

        private void ShowDetails(object sender, SelectionChangedEventArgs e)
        {
            //MessageBox.Show((spCarId.SelectedItem as Car).ToString());
            mySp.Visibility = Visibility.Visible;
            DetailsName.Visibility = Visibility.Visible;
            FontSize = 18;
            carId.Text = (spCarId.SelectedItem as Car).CarId;
            seats.Text = (spCarId.SelectedItem as Car).Seats.ToString();
            isSport.Text = (spCarId.SelectedItem as Car).IsSport.ToString();
            price.Text = (spCarId.SelectedItem as Car).Price.ToString();
            color.Text = (spCarId.SelectedItem as Car).Color;
            manufactoredDate.Text = (spCarId.SelectedItem as Car).ManufactoredDate.ToString();
            //mySp.Visibility = Visibility.Visible;

        }
    }
}
