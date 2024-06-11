using MyTask.Entities;
using System.Windows.Controls;

namespace MyTask.Components
{
    /// <summary>
    /// Interaction logic for ProductUserControl.xaml
    /// </summary>
    public partial class ProductUserControl : UserControl
    {
        public static Products infoProducts;
        public ProductUserControl()
        {
            InitializeComponent();
        }

        public void SetData(Products products)
        {
            long id = CategoryUserControl.CID;
            if (id == products.CategoryId)
            {
                ProductName.Content = products.Name;
            }
            //string image = $"{AuthAPI.BASE_URL_IMG}" + post.ImagePath;
            //Uri imageUri = new Uri(image, UriKind.Absolute);

            //StorageImage.ImageSource = new BitmapImage(imageUri);
        }
    }
}
