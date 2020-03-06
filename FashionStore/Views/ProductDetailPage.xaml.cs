using System;
using System.Collections.Generic;
using Plugin.SharedTransitions;
using Xamarin.Forms;

namespace FashionStore.Views
{
    public partial class ProductDetailPage : ContentPage
    {
        bool MoreLikeSectionIsOpen;
        public ProductDetailPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
            favBtn.TranslateTo(0, 70, 100, Easing.Linear);

            shareBtn.TranslateTo(0, 70, 100, Easing.Linear);

            priceContainer.ScaleTo(0, 100, Easing.Linear);
            priceContainer.TranslateTo(0, 100, 100, Easing.Linear);

            sizeContainer.ScaleTo(0, 100, Easing.Linear);
            sizeContainer.TranslateTo(0, 100, 100, Easing.Linear);

            productName.FadeTo(0, 100, Easing.Linear);

        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            shareBtn.TranslateTo(0, 0, 250, Easing.Linear);
            favBtn.TranslateTo(0, 0, 400, Easing.Linear);

            priceContainer.TranslateTo(0, 0, 300, Easing.Linear);
            priceContainer.ScaleTo(1, 300, Easing.Linear);

            sizeContainer.TranslateTo(0, 0, 300, Easing.Linear);
            sizeContainer.ScaleTo(1, 300, Easing.Linear);

            productName.FadeTo(1, 400, Easing.Linear);


        }

        void MoreLikeSectionToggle(System.Object sender, System.EventArgs e)
        {
            Animation animate;
            if (MoreLikeSectionIsOpen)
            {
                animate = new Animation(d => moreLikeSection.HeightRequest = d, 460, 60);
            }
            else
            {
                animate = new Animation(d => moreLikeSection.HeightRequest = d, 60, 460);
            }
            animate.Commit(moreLikeSection, "MoreLikeSectionToggleAnimation", 60, 700, Easing.CubicOut);
            MoreLikeSectionIsOpen = !MoreLikeSectionIsOpen;
        }
    }
}
