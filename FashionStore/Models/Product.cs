using System;
using System.ComponentModel;

namespace FashionStore.Models
{
    public class Product : INotifyPropertyChanged
    {
        public string Name { get; set; }
        public string Price { get; set; }
        public string Photo { get; set; }
        public bool IsFavorite { get; set; }
        public string Description { get; set; }
        public int Id { get;  set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
