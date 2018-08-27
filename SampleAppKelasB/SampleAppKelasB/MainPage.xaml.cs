using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SampleAppKelasB
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            btnAdd.Clicked += BtnAdd_Clicked;
            btnEdit.Clicked += BtnEdit_Clicked;
		}

        private void BtnEdit_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnAdd_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Keterangan", "Anda memilih tombol Add", "OK");
        }
    }
}
