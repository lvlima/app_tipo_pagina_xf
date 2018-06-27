using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace app_tipo_pagina_xf.TipoPagina.Master
{
    public partial class Master : MasterDetailPage
    {
        public Master()
        {
            InitializeComponent();
        }

        private void MudarPagina1(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Navigation.Pagina01());
            IsPresented = false;
        }

        private void MudarPagina2(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Navigation.Pagina02());
            IsPresented = false;
        }

        private void MudarPagina3(object sender, EventArgs args)
        {
            Detail = new Conteudo();
            IsPresented = false;
        }
    }
}
