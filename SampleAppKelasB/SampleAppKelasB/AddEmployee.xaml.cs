using SampleAppKelasB.DAL;
using SampleAppKelasB.Models;
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
    public partial class AddEmployee : ContentPage
    {
        private DataAccess db;
        public AddEmployee()
        {
            InitializeComponent();
            db = new DataAccess();
        }

        private async void btnSave_Clicked(object sender, EventArgs e)
        {
            var newEmp = new Employee
            {
                EmpName = txtEmpName.Text,
                Designation = txtDesignation.Text,
                Department = txtDepartment.Text,
                Qualification = txtQualification.Text
            };
            try
            {
                int hasil = db.InsertEmployee(newEmp);
                await DisplayAlert("Keterangan", $"Data berhasil ditambah, hasil:{hasil}", "OK");
                await Navigation.PopAsync();
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message,"OK");
            }
        }
    }
}