using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AspireBank.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaInicial : ContentPage
    {
        double saldo;
        double fatura;
        double limite = 2500;
        public PaginaInicial()
        {
            InitializeComponent();

            pagar.Source = ImageSource.FromResource("AspireBank.Img.pagar.png");
            pixx.Source = ImageSource.FromResource("AspireBank.Img.pix.png");
            banco.Source = ImageSource.FromResource("AspireBank.Img.banco.png");

            saldo = 1274.45;
            fatura = 78.87;
            limite -= fatura;
            LblSaldo.Text = saldo.ToString("C");
            LblFatura.Text = fatura.ToString("C");
            LblLimite.Text = limite.ToString("C");

            

            NavigationPage.SetHasNavigationBar(this, false);
            

        }

        public static string[] explode(string separator, string source)
        {
        return source.Split(new string[] { separator }, StringSplitOptions.None);
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
                bool confirm = await DisplayAlert("Tem Certeza?", "Deseja deslogar sua conta?", "Sim", "Não");

                if (confirm)
                {
                    App.Current.Properties.Remove("usuario_logado");

                    App.Current.MainPage = new Login();
                }
                else throw new Exception("Falha ao fazer logout");


            }
            catch (Exception ex)
            {
                await DisplayAlert("error", ex.Message, "OK");
            }
        }

        private void imgpix(object sender, EventArgs e)
        {
        Navigation.PushAsync(new Pix());
        }

        private void btnHide(object sender, EventArgs e)
        {
            if (LblSaldo.Text == saldo.ToString("C"))
            {
                eyebutton.Source = "eyes.png";
                LblSaldo.Text = "━━━━━━";
            }
            else
            {
                LblSaldo.Text = saldo.ToString("C");
                eyebutton.Source = "eyecross.png";
            }
        }
    }
}