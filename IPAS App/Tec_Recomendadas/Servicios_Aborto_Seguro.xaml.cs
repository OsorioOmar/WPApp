using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Tasks;

namespace IPAS_App
{
    public partial class Servicios_Aborto_Seguro : PhoneApplicationPage
    {
        public Servicios_Aborto_Seguro()
        {
            InitializeComponent();
        }

        private void HyperlinkButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            WebBrowserTask webBrowserTask = new WebBrowserTask();
            webBrowserTask.Uri = new Uri("http://ipasmexico.org", UriKind.Absolute);
            webBrowserTask.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            this.NavigationService.Navigate(new Uri("/Tec_Recomendadas/Principal_Tec_Recomendadas.xaml", UriKind.RelativeOrAbsolute));
        }

        private void ZoomInBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (RTB1.FontSize <= 23)
            {
                RTB1.FontSize += 1;
            }
        }

        private void ZoomOutBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (RTB1.FontSize >= 18)
            {
                RTB1.FontSize -= 1;
            }
        }
    }
}