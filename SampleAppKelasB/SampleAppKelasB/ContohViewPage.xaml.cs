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
            btnGetNegara.Clicked += BtnGetNegara_Clicked;

            var listNegara = new List<string> { "Indonesia", "Singapore", "Malaysia", "Thailand", "Japan" };
            pickerNegara.ItemsSource = listNegara;

            pickerNegara.SelectedIndexChanged += PickerNegara_SelectedIndexChanged;
        }

        private void PickerNegara_SelectedIndexChanged(object sender, EventArgs e)
        {
            var listKota = new List<string>();
            var picker = (Picker)sender;
            var data = pickerNegara.Items[pickerNegara.SelectedIndex];
            if (data == "Indonesia")
            {
                listKota.Clear();
                listKota.Add("Jakarta");
                listKota.Add("Jogjakarta");
            }else if (data == "Malaysia")
            {
                listKota.Clear();
                listKota.Add("Kuala Lumpur");
                listKota.Add("Penang");
            }
            pickerKota.ItemsSource = listKota;
        }

        private void BtnGetNegara_Clicked(object sender, EventArgs e)
        {
            var data = pickerNegara.Items[pickerNegara.SelectedIndex];
            DisplayAlert("Keterangan", $"Anda memilih negara: {data}", "OK");
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