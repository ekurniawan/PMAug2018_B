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
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            menuSimpleList.Clicked += MenuNavigation_Clicked;
            menuTextList.Clicked += MenuNavigation_Clicked;
            menuKalkulator.Clicked += MenuNavigation_Clicked;
            menuProductList.Clicked += MenuNavigation_Clicked;
        }

        private void MenuNavigation_Clicked(object sender, EventArgs e)
        {
            var menu = sender as ToolbarItem;
            if(menu.Text== "Simple List")
            {
                Navigation.PushAsync(new SimpleListPage());
            }
            else if(menu.Text== "Text List")
            {
                Navigation.PushAsync(new TextListPage());
            }
            else if(menu.Text== "Product List")
            {
                Navigation.PushAsync(new ProductListPage());
            }
            else
            {
                Navigation.PushAsync(new KalkulatorPage());
            }
        }

        private void btnSimpleList_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SimpleListPage());
        }

        private void btnTextListView_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TextListPage());
        }
    }
}