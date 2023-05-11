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
    public partial class PaginaInicial : ContentPage
    {
        public PaginaInicial()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                App.Current.MainPage = new NavigationPage(new Login());
            }
            catch (Exception ex)
            {
                DisplayAlert("error", ex.Message, "OK");
            }
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
           try
            {
              bool confirm = await DisplayAlert("Tem Certeza?", "Vai fazer o logout da sua conta?", "Sim", "Não");

                if (confirm)
                {
                    App.Current.Properties.Remove("usuario_logado");

                    App.Current.MainPage = new Login();
                }
               else throw new Exception("Falha ao fazer logout");


            }
           catch (Exception ex)
           {
               DisplayAlert("error", ex.Message, "OK");
           }
        }
    }
}