using System;
using System.Collections.Generic;
using FashionStore.Models;
using Prism.Commands;
using Xamarin.Forms;

namespace FashionStore.Components
{
    public partial class ProductComponent : Grid
    {

        public static readonly BindableProperty ProductProperty =
                   BindableProperty.Create(nameof(Product), typeof(Product), typeof(ProductComponent), new Product(), BindingMode.TwoWay);


        public Product Product
        {
            get { return (Product)GetValue(ProductProperty); }
            set { SetValue(ProductProperty, value); }
        }

        public static readonly BindableProperty ToggleFavoriteCommandProperty =
                   BindableProperty.Create(nameof(ToggleFavoriteCommand), typeof(DelegateCommand<Product>), typeof(ProductComponent));


        public DelegateCommand<Product> ToggleFavoriteCommand
        {
            get { return (DelegateCommand<Product>)GetValue(ToggleFavoriteCommandProperty); }
            set { SetValue(ToggleFavoriteCommandProperty, value); }
        }

        public static readonly BindableProperty GoToDetailCommandProperty =
           BindableProperty.Create(nameof(GoToDetailCommand), typeof(DelegateCommand<Product>), typeof(ProductComponent));


        public DelegateCommand<Product> GoToDetailCommand
        {
            get { return (DelegateCommand<Product>)GetValue(GoToDetailCommandProperty); }
            set { SetValue(GoToDetailCommandProperty, value); }
        }

        public ProductComponent()
        {
            InitializeComponent();
        }
    }
}
