using homeWorkMVVM.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;
using Xamarin.Forms;

namespace homeWorkMVVM.ViewModels
{
    public class HttpViewModel
    {
        private const string url = "https://jsonplaceholder.typicode.com/todos";
        private HttpClient _Client = new HttpClient();
        private ObservableCollection<Post> _post;
        protected override async void OnAppearing()
        {
            var content = await _Client.GetStringAsync(url);
            var post = JsonConvert.DeserializeObject<List<Post>>(content);
            _post = new ObservableCollection<Post>(post);
            BindableLayout.SetItemsSource(Post_List, _post);
            base.OnAppearing();
        }

    }
}
