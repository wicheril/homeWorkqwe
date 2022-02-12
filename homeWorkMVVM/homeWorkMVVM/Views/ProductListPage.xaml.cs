using homeWorkMVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace homeWorkMVVM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductListPage : ContentPage
    {
        public ProductListPage()
        {
            InitializeComponent();
            BindingContext = new ProductListViewModel() { Navigation = this.Navigation };
        }

        private void HttpPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HttpPage());
        }
    }
}