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
    public partial class NavigationPage1 : ContentPage
    {
        public NavigationPage1()
        {
            InitializeComponent();
            btnKirim.Clicked += BtnKirim_Clicked;
            btnGlobal.Clicked += BtnGlobal_Clicked;
            btnNavPage2.Clicked += BtnNavPage2_Clicked;
        }

        private void BtnNavPage2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NavigationPage2());
        }

        private void BtnGlobal_Clicked(object sender, EventArgs e)
        {
            Global.Instance.Nama = entryNama.Text;
            Global.Instance.Email = entryEmail.Text;
            DisplayAlert("Keterangan", "Data berhasil disimpan di Global Variable", "OK");
        }

        private void BtnKirim_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NavigationPage2(entryNama.Text,entryEmail.Text));
        }
    }
}