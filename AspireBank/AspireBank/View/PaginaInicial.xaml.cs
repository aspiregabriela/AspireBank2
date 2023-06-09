﻿using System;
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
        public PaginaInicial()
        {
           
            InitializeComponent();

            /** img_logo.Source = ImageSource.FromResource("AspireBank.Img.logo.png");*/
            pix.Source = ImageSource.FromResource("AspireBank.Img.pix.png");
            meuscartoes.Source = ImageSource.FromResource("AspireBank.Img.meus cartoes.png");
            transferencia.Source = ImageSource.FromResource("AspireBank.Img.tranferencia.png");
            pagar.Source = ImageSource.FromResource("AspireBank.Img.pagar .png");
            recarga.Source = ImageSource.FromResource("AspireBank.Img.recarga.png");
            user.Source = ImageSource.FromResource("AspireBank.Img.user.png");

            NavigationPage.SetHasNavigationBar(this, false);

            /**string[] resultsArray = explode (" ", App.DadosUsuario.Usuario);
            string nome = resultsArray[0]; */

            /**txt_correntista.Text = nome;*/

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



private void Button_Clicked_2(object sender, EventArgs e)
{

}

private void ImageButton_Clicked(object sender, EventArgs e)
{

}

private void ImageButton_Clicked_1(object sender, EventArgs e)
{

}

private void ImageButton_Clicked_2(object sender, EventArgs e)
{

}

private void imgpix(object sender, EventArgs e)
{
Navigation.PushAsync(new View.Pix());
}

private void imgtrans(object sender, EventArgs e)
{

}
}
}