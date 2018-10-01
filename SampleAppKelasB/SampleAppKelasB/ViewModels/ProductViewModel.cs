using SampleAppKelasB.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SampleAppKelasB.ViewModels
{
    public class ProductViewModel : BindableObject
    {
        public ProductViewModel()
        {
            listProduct = new List<Product>
            {
                new Product{ProductName="Buah-buahan",Detail="Produk buah-buahan segar",
                    Gambar ="gambarbuah.jpg",Harga=60000},
                new Product{ProductName="Seafood",Detail="Produk Seafood segar (Lobster, Kerang, Kepiting)",
                    Gambar="gambarseafood.jpg",Harga=500000},
                new Product{ProductName="Makanan Olahan Ikan",Detail="Makanan olahan dengan bahan dasar ikan",
                    Gambar="gambarikan.jpg",Harga=200000}
            };
        }

        private List<Product> listProduct;
        public List<Product> ListProduct
        {
            get { return listProduct; }
            set { listProduct = value; OnPropertyChanged("ListProduct"); }
        }

    }
}
