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
        }

        private void BtnKirim_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NavigationPage2(entryNama.Text,entryEmail.Text));
        }
    }
}