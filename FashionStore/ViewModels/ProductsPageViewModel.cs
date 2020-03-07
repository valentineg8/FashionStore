using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using FashionStore.Models;
using FashionStore.Utils;
using FashionStore.Views;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Xamarin.Forms.Internals;

namespace FashionStore.ViewModels
{
    public class ProductsPageViewModel : ViewModelBase
    {
        public ObservableCollection<ProductData> Products { get; set; }
        public int SelectedProductId { get; set; }
        public DelegateCommand<Product> GoToDetailCommand { get; set; }
        public ProductsPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Products = new ObservableCollection<ProductData>();
            GoToDetailCommand = new DelegateCommand<Product>(GoToDetail);
        }
        async void GoToDetail(Product product)
        {
            SelectedProductId = product.Id;
            var navParam = new NavigationParameters { { nameof(product), product } };
            await NavigationService.NavigateAsync($"{nameof(ProductDetailPage)}", navParam);
        }


        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            if (parameters.GetNavigationMode() != NavigationMode.Back)
            {
                LoadProducts();
            }
        }
        void LoadProducts()
        {
            var products = Data.Products.Where(e => e.Category == Category.Tshirt || e.Category == Category.Hoodies).ToArray();
            var pants = Data.Products.Where(e => e.Category == Category.Pants).ToArray();
            for (int i = 0; i < products.Length; i++)
            {
                var element = products[i];
                switch(i)
                {
                    case 4:
                        Products.Add(new ProductData
                        {
                            Title = "Pants you may like",
                            IsSection = true,
                            Items = new List<Product>(pants)
                        });
                        break;
                    default:
                        Products.Add(new ProductData
                        {
                            Item = element
                        });
                        break;

                }
            }
        }

    }
}
