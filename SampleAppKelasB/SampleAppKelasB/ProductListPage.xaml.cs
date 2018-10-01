using SampleAppKelasB.Models;
using SampleAppKelasB.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SampleAppKelasB
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductListPage : ContentPage
    {
        public ProductListPage()
        {
            InitializeComponent();
            this.BindingContext = new ProductViewModel();
            lstProduct.ItemTapped += LstProduct_ItemTapped;
        }

        private void LstProduct_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var data = (Product)e.Item;
            var detailPage = new DetailProductPage();
            detailPage.BindingContext = data;
            Navigation.PushAsync(detailPage);
            //DisplayAlert("Product", $"Anda memilih product {data.ProductName}", "OK");
        }

    }
}