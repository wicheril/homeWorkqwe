using homeWorkMVVM.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace homeWorkMVVM
{
    public partial class App : Application
    {
        public App()
        {
            MainPage = new NavigationPage(new ProductListPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
