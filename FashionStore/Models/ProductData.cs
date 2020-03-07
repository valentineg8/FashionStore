using System.Collections.Generic;
using System.ComponentModel;

namespace FashionStore.Models
{
    public class ProductData : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string Title { get; set; }
        public bool IsSection { get; set; }
        public Product Item { get; set; }
        public List<Product> Items { get; set; }

    }
}
