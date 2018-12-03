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
    public partial class TodoListPage : ContentPage
    {
        private TodoServices _services;
        public TodoListPage()
        {
            InitializeComponent();
            _services = new TodoServices();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            lstTodoItems.ItemsSource = await _services.GetAllData();
        }

        private async void menuTambah_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TodoInsertPage());
        }
    }
}