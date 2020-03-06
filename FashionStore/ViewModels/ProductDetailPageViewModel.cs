using System;
using Prism.Mvvm;
using System.ComponentModel;
using Prism.Navigation;
using FashionStore.Models;
using Prism.AppModel;
using System.Collections.Generic;
using Prism.Commands;
using FashionStore.Views;
using System.Linq;

namespace FashionStore.ViewModels
{
    public class ProductDetailPageViewModel : ViewModelBase, IAutoInitialize
    {
        public Product Product { get; set; }
        public IEnumerable<Product> Products { get; set; }
        public ProductDetailPageViewModel(INavigationService navigationService) : base(navigationService)
        {
        }
       
    }
}
