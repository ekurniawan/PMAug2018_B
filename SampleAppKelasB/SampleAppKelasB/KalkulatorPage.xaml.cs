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
    public partial class KalkulatorPage : ContentPage
    {
        public KalkulatorPage()
        {
            InitializeComponent();
            btnSubmit.Clicked += BtnSubmit_Clicked;
        }

        private void BtnSubmit_Clicked(object sender, EventArgs e)
        {
            double bil1 = Convert.ToDouble(entryBil1.Text);
            double bil2 = Convert.ToDouble(entryBil2.Text);
            double hasil = bil1 + bil2;
            entryHasil.Text = hasil.ToString();
            /*DisplayAlert("Keterangan", $"Jadi Hasil {bil1} + {bil2} = {hasil}",
                "OK");*/
        }
    }
}