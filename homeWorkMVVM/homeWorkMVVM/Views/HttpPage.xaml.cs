using homeWorkMVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using homeWorkMVVM.Models;

namespace homeWorkMVVM.Views
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HttpPage : ContentPage
    {
        
        public HttpViewModel ViewModel { get; private set; }
        public HttpPage(HttpViewModel vm)
        {
            InitializeComponent();
            ViewModel = vm;
            this.BindingContext = ViewModel;
        }
    }
}