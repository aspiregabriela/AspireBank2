using AspireBank.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspireBank.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AspireBank.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();

            img_logo2.Source = ImageSource.FromResource("AspireBank.Img.logo2.png");

            NavigationPage.SetHasNavigationBar(this, false);
        }



        private async void Button_Clicked_1(object sender, EventArgs e)
        {
          /*  string usuario = txt_cpf.Text;
            string senha = txt_senha.Text;

            string usuario_certo = "57897822800";
            string senha_correta = "1234";
            if (usuario == usuario_certo && senha == senha_correta)
            {
                App.Current.Properties.Add("usuario_logado", usuario);
                App.Current.MainPage = new NavigationPage(new PaginaInicial());
            }
            else
                await DisplayAlert("Ops!", "Usuário ou senha incorretos.", "OK");*/

              try
              {
                 Correntista c = await DataServiceCorrentista.Autorizar(new Correntista
                  {
                      Senha = txt_senha.Text,
                      Cpf = txt_cpf.Text.Replace(".", string.Empty).Replace("-", string.Empty)
                  });

                  if (c.Id != 0)
                  {
                      App.DadosCorrentista = c;

                     // await Navigation.PushAsync(new PaginaInicial());

                      App.Current.MainPage = new NavigationPage(new PaginaInicial());
                  }
                  else
                  {
                      await DisplayAlert("Ops", "ihhh", "OK");
                  }

              }
              catch (Exception ex)
              {
                  await DisplayAlert("Ops", ex.Message, "OK");
                  Console.WriteLine(ex.StackTrace);
              }
          }



            private void Button_Clicked_3(object sender, EventArgs e)
            {
                try
                {
                    App.Current.MainPage = new NavigationPage(new CriarConta());
                }
                catch (Exception ex)
                {
                    DisplayAlert("Error", ex.Message, "OK");
                }
            }
        }
    }

