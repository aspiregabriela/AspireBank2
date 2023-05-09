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
		public CriarConta ()
		{
			InitializeComponent ();

            img_logo.Source = ImageSource.FromResource("AspireBank.Img.logo.png");
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
    }
}