using CarRent.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace CarRent.Views
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