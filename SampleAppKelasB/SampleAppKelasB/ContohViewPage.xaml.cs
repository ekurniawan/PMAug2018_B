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
    public partial class ContohViewPage : ContentPage
    {
        public ContohViewPage()
        {
            InitializeComponent();
            btnGetValue.Clicked += BtnGetValue_Clicked;
            stepperNilai.ValueChanged += StepperNilai_ValueChanged;
            btnRunning.Clicked += BtnRunning_Clicked;
            btnStop.Clicked += BtnStop_Clicked;
        }

        private void BtnStop_Clicked(object sender, EventArgs e)
        {
            actLoading.IsRunning = false;
        }

        private void BtnRunning_Clicked(object sender, EventArgs e)
        {
            actLoading.IsRunning = true;
        }

        private void StepperNilai_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            entryNilai.Text = stepperNilai.Value.ToString();
        }

        private void BtnGetValue_Clicked(object sender, EventArgs e)
        {
            string tanggal = dpTanggal.Date.ToShortDateString();
            DisplayAlert("Keterangan", $"Usia Anda :{sliderUsia.Value}, Setuju? {switchAgree.IsToggled}, Tanggal {tanggal}", "OK");
        }
    }
}