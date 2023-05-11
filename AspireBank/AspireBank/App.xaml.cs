using AspireBank.Model;
using AspireBank.View;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AspireBank
{
    public partial class App : Application
    {
        public List<DadoUsuario> lista_usuario = new List<DadoUsuario>
        {
             new  DadoUsuario()
            {
                Usuario = "gabs",
                Nome = "Gabriela",
                Senha = "1234"
            },
            new DadoUsuario()
            {
                Usuario = "Vitor",
                Nome = "vi",
                Senha = "2222"
            },
            new DadoUsuario()
            {
                Usuario ="ga",
                Nome = "Gabs",
                Senha = "1111"
            },
        };

        public App()
        {
            InitializeComponent();

            if (Properties.ContainsKey("usuario_logado"))
                MainPage = new NavigationPage(new View.PaginaInicial());
            else
                MainPage = new View.Login();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
