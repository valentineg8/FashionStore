using System;
using Prism.Mvvm;
using System.ComponentModel;
using Prism.Navigation;
using FashionStore.Models;
using Prism.AppModel;

namespace FashionStore.ViewModels
{
    public class ProductDetailPageViewModel : ViewModelBase, IAutoInitialize
    {
        public Product Product { get; set; }
        public ProductDetailPageViewModel(INavigationService navigationService) : base(navigationService)
        {
        }
    }
}
