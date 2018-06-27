using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace app_tipo_pagina_xf.TipoPagina.Tabbed
{
    public partial class Abas : TabbedPage
    {
        public Abas()
        {
            InitializeComponent();

            Children.Add(new NavigationPage(new TipoPagina.Navigation.Pagina01()) { Title = "Item 3" });
        }
    }
}
