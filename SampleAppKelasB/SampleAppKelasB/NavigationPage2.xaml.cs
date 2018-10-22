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
    public partial class NavigationPage2 : ContentPage
    {
        public NavigationPage2()
        {
            InitializeComponent();
        }

        public NavigationPage2(string nama,string email)
        {
            InitializeComponent();
            lblNama.Text = $"Nama: {nama} dan Email: {email}";
        }
    }
}