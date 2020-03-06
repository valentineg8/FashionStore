using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using FashionStore.Models;
using FashionStore.Views;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;

namespace FashionStore.ViewModels
{
    public class ProductsPageViewModel : ViewModelBase
    {
        public List<Product> Products { get; set; }
        public int SelectedProductId { get; set; }
        public DelegateCommand<Product> GoToDetailCommand { get; set; }
        public ProductsPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            GoToDetailCommand = new DelegateCommand<Product>(GoToDetail);
        }
        async void GoToDetail(Product product)
        {
            SelectedProductId = product.Id;
            var products = Products.Where(e => e.Id != product.Id);
            var navParam = new NavigationParameters { { nameof(product), product }, { nameof(products), products } };
            await NavigationService.NavigateAsync($"{nameof(ProductDetailPage)}", navParam);
        }


        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            if (parameters.GetNavigationMode() != NavigationMode.Back)
            {
                Products = new List<Product>
                {
                    new Product
                    {
                        Id = 1,
                        Name = "Ameowica",
                        Photo = "https://vangogh.teespring.com/v3/image/EZP5X7Ts0ZjTYEuVCJf7atgh3Og/480/560.jpg",
                        Rating = 4.8,
                        Size = "L",
                        Price = "$24.99",
                        Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.",
                        IsFavorite = false
                    },
                    new Product
                    {
                        Id = 2,
                        Rating = 4.4,
                        Name = "AA BATTERY FUNNY TSHIRT",
                        Size = "M",
                        Photo = "https://vangogh.teespring.com/v3/image/kpGLWhvOtR0xogt24XJRhT7S-mw/480/560.jpg",
                        Price = "$28.99",
                        Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.",
                        IsFavorite = false
                    },
                    new Product
                    {
                        Id = 3,
                        Rating = 4.5,
                        Name = "Save the Amazon",
                        Size = "L",
                        Photo = "https://vangogh.teespring.com/v3/image/nIICjb8m1X3RHfIW2Qz8FVXBY1s/480/560.jpg",
                        Price = "19.99",
                        Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.",
                        IsFavorite = false
                    },
                    new Product
                    {
                        Id = 4,
                        Rating = 4.3,
                        Name = "Inhale. Exhale Scottie",
                        Size = "L",
                        Photo = "https://vangogh.teespring.com/v3/image/oPyLqRosQFMoqcWpJEq2VSvC7xM/480/560.jpg",
                        Price = "19.99",
                        Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.",
                        IsFavorite = false
                    },
                    new Product
                    {
                        Id = 5,
                        Rating = 5,
                        Name = "Save the Amazon Rainforest",
                        Size = "L",
                        Photo = "https://vangogh.teespring.com/v3/image/rlg7BaMN05Hbr1JDdFQMonxPSW4/480/560.jpg",
                        Price = "29.99",
                        Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.",
                        IsFavorite = false
                    },
                    new Product
                    {
                        Id = 6,
                        Rating = 5,
                        Name = "NOPE",
                        Size = "L",
                        Photo = "https://vangogh.teespring.com/v3/image/N8r28I0QHA_8pYK5Y_WGBSSzwiU/480/560.jpg",
                        Price = "29.99",
                        Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.",
                        IsFavorite = false
                    }
                };
            }
        }

    }
}
