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
            InitializeComponent();
            voltar.Source = ImageSource.FromResource("AspireBank.Img.voltar.png");
            Transferencia.Source = ImageSource.FromResource("AspireBank.Img.cobrar.png");
            Deposito.Source = ImageSource.FromResource("AspireBank.Img.bancoo.png");
            QrCode.Source = ImageSource.FromResource("AspireBank.Img.QRCode2.png");
            CadastroPix.Source = ImageSource.FromResource("AspireBank.Img.chavepix.png");


        }

       

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new PaginaInicial());
        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {
            Navigation.PushAsync((new PixEfetuado()));
        }

        private void seta_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PaginaInicial());
        }

        private void voltar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PaginaInicial());
        }

        private void Transferencia_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Transição());
        }

        private void Deposito_Clicked(object sender, EventArgs e)
        {

        }

        private void QrCode_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new QRcode());
        }

        private void CadastroPix_Clicked(object sender, EventArgs e)
        {

        }
    }
}