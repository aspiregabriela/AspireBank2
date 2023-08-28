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
        public static Correntista DadosCorrentista { get; set; }

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
