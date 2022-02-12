using System;
using System.Collections.Generic;
using System.ComponentModel;
using homeWorkMVVM.Models;
using System.Text;

namespace homeWorkMVVM.ViewModels
{
    public class ProductViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        ProductListViewModel lvm;
        public Products Products { get; private set; }

        public ProductViewModel()
        {
            Products = new Products();
        }
        public ProductListViewModel ListViewModel
        { 
            get { return lvm; }
            set
            {
                if (lvm != value)
                { 
                    lvm = value;
                    OnPropertyChanged("ListViewModel");
                }
            }
        }
        public string Name
        {
            get { return Products.Name; }
            set
            {
                if (Products.Name != value)
                {
                    Products.Name = value;
                    OnPropertyChanged("Name");
                }
            }
        }
        public string Description
        {
            get { return Products.Description; }
            set
            {
                if (Products.Description != value)
                {
                    Products.Description = value;
                    OnPropertyChanged("Description");
                }
            }
        }
        public string Price
        {
            get { return Products.Price; }
            set
            {
                if (Products.Price != value)
                {
                    Products.Price = value;
                    OnPropertyChanged("Price");
                }
            }
        }
        public bool IsValid
        {
            get
            {
                return ((!string.IsNullOrEmpty(Name.Trim())) ||
                    (!string.IsNullOrEmpty(Description.Trim())) ||
                    (!string.IsNullOrEmpty(Price.Trim())));
            }
        }
        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}
