using SampleAppKelasB.Models;
using SampleAppKelasB.Services;
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
	public partial class TodoInsertPage : ContentPage
	{
        private TodoServices _services;
        public TodoInsertPage ()
		{
			InitializeComponent ();
            _services = new TodoServices();
		}

        private async void btnSave_Clicked(object sender, EventArgs e)
        {
            var newTodo = new TodoItem
            {
                ID = Guid.NewGuid().ToString(),
                Name = txtName.Text,
                Notes = txtNotes.Text,
                Done = switchDone.IsToggled
            };
            try
            {
                await _services.InsertData(newTodo);
                await Navigation.PopAsync();
            }
            catch (Exception ex)
            {
                await DisplayAlert("Kesalahan", $"Kesalahan:{ex.Message}", "OK");
            }
        }

        private void btnCancel_Clicked(object sender, EventArgs e)
        {

        }
    }
}