using MyTask.Entities;
using MyTask.Entities.ViewModels;
using MyTask.Pages;
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

namespace MyTask.Components
{
    /// <summary>
    /// Interaction logic for CategoryUserControl.xaml
    /// </summary>
    public partial class CategoryUserControl : UserControl
    {
        public long categoryId { get; set; }
        public string categoryName { get; set; }
        public static long CID;
        public Func<Task> Refresh { get; set; }

        public CategoryUserControl()
        {
            InitializeComponent();
        }

        public void SetData(CategoryView category)
        {
            CategoryName.Content = category.Name;
            categoryName = category.Name;
            categoryId = category.Id;
        }

        private void CategoryCheck(object sender, MouseButtonEventArgs e)
        {
            CID = categoryId;
            ProductPage productPage = new ProductPage();
            MainWindow mainWindow = new MainWindow();
            mainWindow.FrameFilter.Content = productPage;
        }
    }
}
