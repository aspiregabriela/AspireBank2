using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using ZXing;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AspireBank.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class scaner : ContentPage
    {
        public scaner()
        {
            InitializeComponent();
            zxing.OnScanResult += (result) => Device.BeginInvokeOnMainThread(() => { lblResult.Text = result.Text; });
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            zxing.IsScanning = true;
        }

        protected override void OnDisappearing()
        {
            zxing.IsScanning = false;

            base.OnDisappearing();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new PaginaInicial();
        }
    }
}