using dog_shelterMVVM_andr.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace dog_shelterMVVM_andr.Views
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