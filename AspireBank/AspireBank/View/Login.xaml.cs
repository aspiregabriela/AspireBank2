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
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();

            img_logo.Source = ImageSource.FromResource("AspireBank.Img.logo.png");

            NavigationPage.SetHasNavigationBar(this, false);
        }

      

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            string usuario = txt_usuario.Text;
            string senha = txt_senha.Text;

            string usuario_certo = "gabs";
            string senha_correta = "1234";
            if (usuario == usuario_certo && senha == senha_correta)
            {
                App.Current.Properties.Add("usuario_logado", usuario);
                App.Current.MainPage = new NavigationPage(new PaginaInicial());
            }
            else
                DisplayAlert("Ops!", "Usuário ou senha incorretos.", "OK");
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
