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

namespace DBProject
{
    /// <summary>
    /// Interaction logic for SFactor.xaml
    /// </summary>
    public partial class SFactor : Window
    {
        public SFactor()
        {
            InitializeComponent();
            List<sFactor_info> items = new List<sFactor_info>();
            items.Add(new sFactor_info() { ID = 1, price = 10, count = 19, date = "2020/10/10", admin = "ادمین", product = "product", costumer = "c"});
            items.Add(new sFactor_info() { ID = 2, price = 10, count = 19, date = "2020/10/10", admin = "ادمین", product = "product", costumer = "c" });
            lvUsers.ItemsSource = items;

            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(lvUsers.ItemsSource);
        }
        private void OnListViewItem_PreviewMouseButtonDown(object sender, MouseButtonEventArgs e)
        {
            ContextMenu cm = this.FindResource("ItemContextMenu") as ContextMenu;
            cm.PlacementTarget = sender as Button;
            cm.IsOpen = true;
        }

        private void DetailButton_Click(object sender, RoutedEventArgs e)
        {
            sFactor_info clickedItem = (sFactor_info)lvUsers.SelectedItem;
            SFactorDetail factorDetail = new SFactorDetail(clickedItem);
            factorDetail.ShowDialog();
        }
        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(string.Format("Removed"));
        }
    }

    public class sFactor_info
    {
        public int ID { set; get; }
        public double price { set; get; }
        public int count { set; get; }
        public string date { set; get; }
        public string admin { set; get; }
        public string costumer { set; get; }
        public string product { set; get; }

    }
}
