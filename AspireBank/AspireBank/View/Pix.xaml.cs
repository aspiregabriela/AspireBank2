using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AspireBank.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pix : ContentPage
    {
        public Pix()
        {
           // setaesquerda.Source = ImageSource.FromResource("AspireBank.Img.setaesquerda.png");

            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);
        }

       

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new PaginaInicial());
        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {
            Navigation.PushAsync((new PixEfetuado()));
        }
    }
}