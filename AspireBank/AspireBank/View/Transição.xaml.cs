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
    public partial class Transição : ContentPage
    {
        public Transição()
        {
            InitializeComponent();
            voltar.Source = ImageSource.FromResource("AspireBank.Img.voltar.png");
            Transferencia.Source = ImageSource.FromResource("AspireBank.Img.cobrar.png");
            Deposito.Source = ImageSource.FromResource("AspireBank.Img.bancoo.png");
        }

        private void setaesquerda_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync((new TransiçãoEfetuada()));
        }

       // private void voltar_Clicked(object sender, EventArgs e)
       // {

       // }

        private void voltar_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PaginaInicial());
        }
    }
}