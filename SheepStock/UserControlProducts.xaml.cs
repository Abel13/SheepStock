using MaterialDesignThemes.Wpf;
using SheepStock.Controller;
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

namespace SheepStock
{
    /// <summary>
    /// Interaction logic for UserControlProducts.xaml
    /// </summary>
    public partial class UserControlProducts : UserControl
    {
        ProductController controller;
        SnackbarMessageQueue messageQueue;
        public UserControlProducts()
        {
            controller = new ProductController();
            InitializeComponent();
            messageQueue = SnackbarThree.MessageQueue;

            this.DataContext = controller;

            ListViewProducts.ItemsSource = controller.GetProducts();
        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(controller.ProductViewModel.Name))
                controller.SaveProduct(controller.ProductViewModel);
            else
            {
                Task.Factory.StartNew(() => messageQueue.Enqueue("Informe o nome do produto!", true));
            }
        }
    }
}
