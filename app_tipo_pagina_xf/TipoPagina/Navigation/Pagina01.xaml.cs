using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace app_tipo_pagina_xf.TipoPagina.Navigation
{
    public partial class Pagina01 : ContentPage
    {
        public Pagina01()
        {
            InitializeComponent();
        }

        private void MudarParaPagina02(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Pagina02());
        }

        private void ChamarModal(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new Pagina03());
        }

        private void ChamarMaster(object sender, EventArgs args)
        {
            App.Current.MainPage = new Master.Master();
        }
    }
}
