using System;
using System.Collections.Generic;
using System.Data;
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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void InitDataGrid()
        {
            DataTable dt = new DataTable();
            DataColumn id = new DataColumn("id", typeof(int));
            DataColumn name = new DataColumn("name", typeof(string));
            DataColumn phone = new DataColumn("phone", typeof(string));
            DataColumn email = new DataColumn("email", typeof(string));
            DataColumn address= new DataColumn("address", typeof(string));

            dt.Columns.Add(id);
            dt.Columns.Add(name);
            dt.Columns.Add(phone);
            dt.Columns.Add(email);
            dt.Columns.Add(address);

            DataRow firstRow = dt.NewRow();
            firstRow[0] = 1;
            firstRow[1] = "qwe";
            firstRow[2] = "123-456-789";
            firstRow[3] = "qwe@gmail.com";
            firstRow[4] = "asd";
            DataRow secodRow = dt.NewRow();
            firstRow[0] = 2;
            firstRow[1] = "rty";
            firstRow[2] = "789-456-789";
            firstRow[3] = "rty@gmail.com";
            firstRow[4] = "fgh";

            dt.Rows.Add(firstRow);
            dt.Rows.Add(secodRow);

            myDG.ItemsSource = dt.DefaultView;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            InitDataGrid();
        }
    }
}