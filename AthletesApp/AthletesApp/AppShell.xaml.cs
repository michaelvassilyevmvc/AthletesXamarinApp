using AthletesApp.ViewModels;
using AthletesApp.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace AthletesApp
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
