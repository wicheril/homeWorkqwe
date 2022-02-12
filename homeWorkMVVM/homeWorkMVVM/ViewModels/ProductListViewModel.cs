using homeWorkMVVM.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace homeWorkMVVM.ViewModels
{
    public class ProductListViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<ProductViewModel> Products { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand CreateProductCommand { get; protected set; }
        public ICommand CreateHttpCommand { get; protected set; }
        public ICommand DeleteProductCommand { get; protected set; }
        public ICommand SaveProductCommand { get; protected set; }
        public ICommand BackCommand { get; protected set; }
        ProductViewModel selectedProduct;
        public INavigation Navigation { get; set; }

        public ProductListViewModel()
        {
            Products = new ObservableCollection<ProductViewModel>();
            DeleteProductCommand = new Command(DeleteProduct);
            SaveProductCommand = new Command(SaveProduct);
            BackCommand = new Command(Back);
        }
        private void CreateProduct()
        {
            Navigation.PushAsync(new ProductPage(new ProductViewModel() { ListViewModel = this }));
        }
        public ProductViewModel SelectedProduct
        {
            get { return selectedProduct; }
            set
            {
                if (selectedProduct != value)
                {
                    ProductViewModel tempProduct = value;
                    selectedProduct = null;
                    OnPropertyChanged("SelectedProduct");
                    Navigation.PushAsync(new ProductPage(tempProduct));
                }
            }
        }
        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
        private void Back()
        {
            Navigation.PopAsync();
        }
        private void SaveProduct(object productObject)
        {
            ProductViewModel product = productObject as ProductViewModel;
            try
            {
                if (product != null && product.IsValid && !Products.Contains(product))
                {
                    Products.Add(product);
                }
                Back();
            }
            catch (Exception)
            {
            }
        }
        private void DeleteProduct(object productObject)
        {
            ProductViewModel product = productObject as ProductViewModel;
            if (product != null)
            {
                Products.Remove(product);
            }
            Back();
        }
    }
}
