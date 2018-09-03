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
    public partial class KelipatanPage : ContentPage
    {
        public KelipatanPage()
        {
            InitializeComponent();
            btnCheck.Clicked += BtnCheck_Clicked;
        }

        private void BtnCheck_Clicked(object sender, EventArgs e)
        {
            
        }
    }
}