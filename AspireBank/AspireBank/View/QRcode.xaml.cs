using QRCoder;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AspireBank.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QRcode : ContentPage
    {
        public QRcode()
        {
            InitializeComponent();
        }

        

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            string teste = "Chave da Transferência:" + App.DadosCorrentista.Id;

            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(teste, QRCodeGenerator.ECCLevel.Q);
            PngByteQRCode qRCode = new PngByteQRCode(qrCodeData);
            byte[] qrCodeBytes = qRCode.GetGraphic(20);
            setaesquerda.Source = ImageSource.FromStream(() => new MemoryStream(qrCodeBytes));
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new PaginaInicial());
        }
    }
}