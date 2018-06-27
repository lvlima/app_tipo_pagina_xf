using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace app_tipo_pagina_xf.TipoPagina.Navigation
{
    public partial class Pagina03 : ContentPage
    {
        public Pagina03()
        {
            InitializeComponent();
        }

        private void FecharModal(object sender, EventArgs args)
        {
            Navigation.PopModalAsync();    
        }
    }
}
