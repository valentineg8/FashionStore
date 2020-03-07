using System;
using System.Collections.Generic;
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

        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            shareBtn.TranslateTo(0, 0, 300, Easing.CubicOut);
            favBtn.TranslateTo(0, 0, 500, Easing.CubicOut);

            moreLikeBtn.TranslateTo(0, 0, 500, Easing.CubicOut);

            priceContainer.TranslateTo(0, 0, 400, Easing.CubicOut);
            priceContainer.ScaleTo(1, 400, Easing.CubicOut);

            sizeContainer.TranslateTo(0, 0, 400, Easing.CubicOut);
            sizeContainer.ScaleTo(1, 400, Easing.CubicOut);

            productName.FadeTo(1, 500, Easing.CubicOut);
            productName.TranslateTo(0, 0, 500, Easing.CubicOut);


        }

        void MoreLikeSectionToggle(System.Object sender, System.EventArgs e)
        {
            Animation animateSection;
            if (MoreLikeSectionIsOpen)
            {
                animateSection = new Animation(d => moreLikeSection.HeightRequest = d, 350, 60);
            }
            else
            {
                animateSection = new Animation(d => moreLikeSection.HeightRequest = d, 60, 350);
            }
            animateSection.Commit(moreLikeSection, "MoreLikeSectionToggleAnimation", 60, 500, Easing.CubicOut);
            MoreLikeSectionIsOpen = !MoreLikeSectionIsOpen;
            moreLikeArrow.RotateTo(MoreLikeSectionIsOpen ? 180 : 0, 300, Easing.Linear);
        }
    }
}
