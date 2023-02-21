using MigrationDemo.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace MigrationDemo.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}