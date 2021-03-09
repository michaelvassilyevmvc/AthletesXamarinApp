using AthletesApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace AthletesApp.Views
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