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
	public partial class SimpleListPage : ContentPage
	{
        private List<string> lstNama;
		public SimpleListPage ()
		{
			InitializeComponent ();
            lstNama = new List<string>()
            {
                "Erick","Budi","Argo","Halim","Katon"
            };

            lvData.ItemsSource = lstNama;
            lvData.ItemTapped += LvData_ItemTapped;
		}

        private void LvData_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var nama = e.Item.ToString();
            DisplayAlert("Keterangan", $"Anda memilih {nama}", "OK");
            ((ListView)sender).SelectedItem = null;
        }
    }
}