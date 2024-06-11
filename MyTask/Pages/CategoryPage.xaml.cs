using MyTask.BLL.Interfaces;
using MyTask.BLL.Services;
using MyTask.Components;
using MyTask.Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for CategoryPage.xaml
    /// </summary>
    public partial class CategoryPage : Page
    {
        private readonly CategoryService _service;
        public CategoryPage()
        {
            InitializeComponent();
            _service = new CategoryService();
        }
        public async Task RefreshAsync()
        {
            WPCategory.Children.Clear();
            var datas = await _service.GetAllCategories();
            foreach (var data in datas)
            {
                CategoryUserControl control = new CategoryUserControl();
                control.SetData(data);
                WPCategory.Children.Add(control);
            }
        }

        private async void CategoryLoad(object sender, RoutedEventArgs e)
        {
            await RefreshAsync();
        }
    }
}
