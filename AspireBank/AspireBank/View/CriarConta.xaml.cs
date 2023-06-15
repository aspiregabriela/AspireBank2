using AspireBank.Model;
using AspireBank.Service;
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
	public partial class CriarConta : ContentPage
	{
		public CriarConta()
		{
			InitializeComponent();

			img_logo.Source = ImageSource.FromResource("AspireBank.Img.logo.png");
		}

		private async void Button_Clicked(object sender, EventArgs e)
		{
            try
            {

                await DataServiceCorrentista.Cadastrar(new Correntista
                {
                    nome = txt_nome.Text,
                    data_Nasc = txt_dataNasc.Date,
                    cpf = txt_cpf.Text,
                    senha = txt_senha.Text
                });

                await DisplayAlert("Sucesso!", "Você foi cadastrado.", "OK");
                await Navigation.PushAsync(new MainPage());

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops", ex.Message, "OK");

            }
            finally
            {
                //carregando.IsRunning = false;
                //carregando.IsVisible = false;//
            }
        }
    }
}

