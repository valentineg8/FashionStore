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
using FashionStore.Utils;

namespace FashionStore.ViewModels
{
    public class ProductDetailPageViewModel : ViewModelBase, IAutoInitialize
    {
        public Product Product { get; set; }
        public List<Product> Products { get; set; }
        public ProductDetailPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Products = new List<Product>();
        }
        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);
            if (parameters.GetNavigationMode() != NavigationMode.Back)
            {
                var products = Data.Products.Where(e => e.Category == Product.Category && e.Id != Product.Id).ToArray();
                Products = new List<Product>(products);
            }
        }
    }
}
