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
    public partial class Recarga : ContentPage
    {
        public Recarga()
        {
            InitializeComponent();
        }

        private void setaesquerda_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync((new RecargaEfetuada()));
        }
    }
}