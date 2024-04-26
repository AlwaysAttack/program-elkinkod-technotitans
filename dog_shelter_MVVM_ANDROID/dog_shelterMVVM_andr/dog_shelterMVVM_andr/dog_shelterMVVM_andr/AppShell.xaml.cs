using dog_shelterMVVM_andr.ViewModels;
using dog_shelterMVVM_andr.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace dog_shelterMVVM_andr
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
