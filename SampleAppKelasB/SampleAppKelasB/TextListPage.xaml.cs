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
    public partial class TextListPage : ContentPage
    {
        public TextListPage()
        {
            InitializeComponent();
            this.BindingContext = new BeritaViewModel();
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var data = (Berita)e.Item;
            DisplayAlert("Keterangan", 
                $"Judul:{data.Judul} dan Deksripsi:{data.Deskripsi}", "OK");
            ((ListView)sender).SelectedItem = null;
        }
    }
}