using System;
using FashionStore.Models;
using Xamarin.Forms;

namespace FashionStore.Utils
{
    public class ProductTemplateSelector : DataTemplateSelector
    {
        public DataTemplate ProductTemplate { get; set; }
        public DataTemplate ProductsTemplate { get; set; }
        public ProductTemplateSelector()
        {
        }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            return ((ProductData)item).IsSection  ? ProductsTemplate : ProductTemplate;
        }
    }
}
