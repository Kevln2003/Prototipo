﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Prototipo.Visual.Pediatrico;
using Prototipo.Visual.Plantillas;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Prototipo.Visual.Pediatrico
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Pediatria : Page
    {
        public Pediatria()
        {
            this.InitializeComponent();
            Modulos.NavigationRequested += OnNavigationRequested;
        }
        private void OnNavigationRequested(object sender, string pageType)
        {
            if (pageType == "Formulario")
            {
                ContentFrame.Navigate(typeof(OpcionesPediatria));


            }
            if (pageType == "Facturacion")
            {
                ContentFrame.Navigate(typeof(Facturacion));
            }
            if (pageType == "Historial")
            {
                ContentFrame.Navigate(typeof(Historial));
            }
            if (pageType == "Diagnostico")
            {
                ContentFrame.Navigate(typeof(Diagnostico));
            }
            if (pageType == "Agendamiento")
            {
                ContentFrame.Navigate(typeof(Agendamiento));
            }
            if (pageType == "Administracion")
            {
                ContentFrame.Navigate(typeof(Administracion));
            }
            if (pageType == "Ayuda")
            {
                ContentFrame.Navigate(typeof(Ayuda));
            }


        }
    }
}
