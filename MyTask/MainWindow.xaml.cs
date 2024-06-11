using MyTask.Pages;
using System.Windows;

namespace MyTask
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuRadioButton(object sender, RoutedEventArgs e)
        {
            CategoryPage page2 = new CategoryPage();
            FrameFilterCategory.Content = page2;

            ProductPage page3 = new ProductPage();
            FrameFilter.Content = page3;
        }
    }
}
