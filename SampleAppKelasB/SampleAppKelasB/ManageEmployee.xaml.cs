using SampleAppKelasB.DAL;
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
    public partial class ManageEmployee : ContentPage
    {
        private DataAccess db;
        public ManageEmployee()
        {
            InitializeComponent();
            db = new DataAccess();
            lstEmployee.ItemsSource = db.GetAllEmployees();
        }

        private void btnAdd_Clicked(object sender, EventArgs e)
        {

        }
    }
}