﻿using System;
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

            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {

        }

        private void ImageButton_Clicked_1(object sender, EventArgs e)
        {

        }

        private void bntcobrar(object sender, EventArgs e)
        {

        }

        private void bntbanco(object sender, EventArgs e)
        {

        }

        private void btncopiaecola(object sender, EventArgs e)
        {

        }

        private void btnqrcode(object sender, EventArgs e)
        {

        }
    }
}