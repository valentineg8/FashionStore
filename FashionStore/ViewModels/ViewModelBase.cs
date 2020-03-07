using System;
using System.ComponentModel;
using FashionStore.Models;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;

namespace FashionStore.ViewModels
{
    public class ViewModelBase : BindableBase, INavigationAware, IDestructible, INotifyPropertyChanged
    {
        protected INavigationService NavigationService { get; private set; }

        public DelegateCommand<Product> ToggleFavoriteCommand { get; set; }

        public ViewModelBase(INavigationService navigationService)
        {
            ToggleFavoriteCommand = new DelegateCommand<Product>(ToggleFavorite);
            NavigationService = navigationService;
        }

        void ToggleFavorite(Product product)
        {
            product.IsFavorite = !product.IsFavorite;
        }

        internal void OnNavigatedTo()
        {
            throw new NotImplementedException();
        }

        public virtual void OnNavigatedFrom(INavigationParameters parameters)
        {

        }

        public virtual void OnNavigatedTo(INavigationParameters parameters)
        {

        }

        public virtual void OnNavigatingTo(INavigationParameters parameters)
        {

        }

        public virtual void Destroy()
        {

        }
    }
}
