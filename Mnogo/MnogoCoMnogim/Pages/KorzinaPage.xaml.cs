using MnogoCoMnogim.Models;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MnogoCoMnogim.Pages
{
    /// <summary>
    /// Логика взаимодействия для KorzinaPage.xaml
    /// </summary>
    public partial class KorzinaPage : Page
    {
        Order contextOrder;
        public KorzinaPage()
        {
            InitializeComponent();
            CBNameOrder.ItemsSource = App.DB.Product.ToList();
            contextOrder = new Order();
        }

        private void BAdd_Click(object sender, RoutedEventArgs e)
        {
            var selectedProduct = CBNameOrder.SelectedItem as Product;
            var orderProduct = new OrderProduct();
            orderProduct.Product = selectedProduct;
            contextOrder.OrderProduct.Add(orderProduct);
            DGOrder.ItemsSource = contextOrder.OrderProduct.ToList();
        }      

        private void BAddOrder_Click_1(object sender, RoutedEventArgs e)
        {
        }
    }
}
