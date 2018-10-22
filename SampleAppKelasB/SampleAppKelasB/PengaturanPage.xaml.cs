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
	public partial class PengaturanPage : ContentPage
	{
		public PengaturanPage ()
		{
			InitializeComponent ();
            btnSave.Clicked += BtnSave_Clicked;
		}

        protected override void OnAppearing()
        {
            if (Application.Current.Properties.ContainsKey("Notifikasi"))
            {
                swNotifikasi.IsToggled = Convert.ToBoolean(Application.Current.Properties["Notifikasi"]);
            }
        }

        private void BtnSave_Clicked(object sender, EventArgs e)
        {
            Application.Current.Properties["Notifikasi"] = swNotifikasi.IsToggled;
            DisplayAlert("Keterangan", "Data sudah disimpan kedalam app current", "OK");
        }
    }
}