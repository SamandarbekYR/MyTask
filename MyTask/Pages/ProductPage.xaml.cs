using MyTask.BLL.Services;
using MyTask.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

namespace MyTask.Pages
{
    /// <summary>
    /// Interaction logic for ProductPage.xaml
    /// </summary>
    public partial class ProductPage : Page
    {
        public readonly ProductService _service;
        public ProductPage()
        {
            InitializeComponent();
            _service = new ProductService();
        }
        public async Task Refresh ()
        {
            WPProduct.Children.Clear();
           var datas = await _service.GetProductsAsync();

            foreach (var data in datas)
            {
                ProductUserControl control = new ProductUserControl();
                control.SetData(data);
                WPProduct.Children.Add(control);
            }
        }

        private async void ProductLoad(object sender, RoutedEventArgs e)
        {
            await Refresh();
        }
    }
}
