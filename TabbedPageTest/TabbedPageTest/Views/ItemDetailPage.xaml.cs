using System.ComponentModel;
using TabbedPageTest.ViewModels;
using Xamarin.Forms;

namespace TabbedPageTest.Views
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