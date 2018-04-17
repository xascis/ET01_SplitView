using System;
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

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace ET01_SplitView
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void TextBlock_Tapped(object sender, TappedRoutedEventArgs e)
        {
            miCuadro.Navigate(typeof(Contenido1));
            Titulo.Text = "Opción 1";
        }

        private void TextBlock_Tapped_1(object sender, TappedRoutedEventArgs e)
        {
            miCuadro.Navigate(typeof(Contenido2));
            Titulo.Text = "Opción 2";
        }

        private void TextBlock_Tapped_2(object sender, TappedRoutedEventArgs e)
        {
            miCuadro.Navigate(typeof(Contenido3));
            Titulo.Text = "Opción 3";
        }

        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            miVistaPartida.DisplayMode = SplitViewDisplayMode.CompactInline;
        }

        private void AppBarButton_Click_1(object sender, RoutedEventArgs e)
        {
            miVistaPartida.DisplayMode = SplitViewDisplayMode.CompactOverlay;
        }

        private void AppBarButton_Click_2(object sender, RoutedEventArgs e)
        {
            miVistaPartida.DisplayMode = SplitViewDisplayMode.Inline;
        }

        private void AppBarButton_Click_3(object sender, RoutedEventArgs e)
        {
            miVistaPartida.DisplayMode = SplitViewDisplayMode.Overlay;
        }

        private void AppBarButton_Click_4(object sender, RoutedEventArgs e)
        {
            miVistaPartida.IsPaneOpen = !miVistaPartida.IsPaneOpen;
        }

        private void Hamburguesa_Click(object sender, RoutedEventArgs e)
        {
            miVistaPartida.IsPaneOpen = !miVistaPartida.IsPaneOpen;
        }

        private void Page_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (this.ActualWidth > 700)
            {
                miVistaPartida.IsPaneOpen = true;
            } else
            {
                miVistaPartida.IsPaneOpen = false;
            }
        }

        private void miCuadro_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
