using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using FashionStore.Models;
using Prism.Commands;
using Prism.Mvvm;

namespace FashionStore.ViewModels
{
    public class ProductsPageViewModel : BindableBase, INotifyPropertyChanged
    {
        public ObservableCollection<Product> Products { get; set; }
        public DelegateCommand<Product> ToggleFavoriteCommand { get; set; }
        public ProductsPageViewModel()
        {
            ToggleFavoriteCommand = new DelegateCommand<Product>(ToggleFavorite);
            Products = new ObservableCollection<Product>
            {
                new Product
                {
                    Id = 1,
                    Name = "Tshirt DuCast White",
                    Photo = "thsirt1.jpg",
                    Price = "$24.99",
                    Description = "Lorem asd asd as da sd",
                    IsFavorite = false
                },
                new Product
                {
                    Id = 2,
                    Name = "Tshirt 2",
                    Photo = "tshirt2.jpg",
                    Price = "$28.99",
                    Description = "Lorem asd asd as da sd",
                    IsFavorite = false
                }
            };
        }
        void ToggleFavorite(Product product)
        {
            product.IsFavorite = !product.IsFavorite;
        }
    }
}
