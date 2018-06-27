using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace app_tipo_pagina_xf.TipoPagina.Carousel
{
    public partial class TipoPagina03 : ContentPage
    {
        public TipoPagina03()
        {
            InitializeComponent();
        }

        private void MudarPagina(Object sender, EventArgs args)
        {
            //App.Current.MainPage = new NavigationPage(new Navigation.Pagina01()) { BarBackgroundColor = Color.Blue};
            App.Current.MainPage = new Tabbed.Abas();
        }
    }
}
