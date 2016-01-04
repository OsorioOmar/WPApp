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
using System.Windows.Media.Imaging;

namespace IPAS_App
{
    public partial class Metodos_Recomendados : PhoneApplicationPage
    {
        public Metodos_Recomendados()
        {
            InitializeComponent();

            whiteGrid.Visibility = Visibility.Collapsed;
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

        private void HyperlinkButton_Click2(object sender, System.Windows.RoutedEventArgs e)
        {
			WebBrowserTask webBrowserTask = new WebBrowserTask();
            webBrowserTask.Uri = new Uri("http://www.who.int/reproductivehealth/publications/unsafe_abortion/abortion-task-shifting/en/", UriKind.Absolute);
            webBrowserTask.Show();
        }
		
		private void HyperlinkButton_Click3(object sender, System.Windows.RoutedEventArgs e)
        {
			WebBrowserTask webBrowserTask = new WebBrowserTask();
            webBrowserTask.Uri = new Uri("http://ipasmexico.org/act-clinicas.html", UriKind.Absolute);
            webBrowserTask.Show();
        }

		private void ZoomInBtn_Click(object sender, System.Windows.RoutedEventArgs e)
		{
            if (RTB1.FontSize <= 23)
            {
                RTB1.FontSize += 1;
                RTB2.FontSize += 1;
                RTB3.FontSize += 1;
                RTB4.FontSize += 1;
                RTB5.FontSize += 1;
                RTB6.FontSize += 1;
                RTB7.FontSize += 1;
                RTB8.FontSize += 1;
                RTB9.FontSize += 1;
            }
		}

		private void ZoomOutBtn_Click(object sender, System.Windows.RoutedEventArgs e)
		{
            if (RTB1.FontSize >= 18)
            {
                RTB1.FontSize -= 1;
                RTB2.FontSize -= 1;
                RTB3.FontSize -= 1;
                RTB4.FontSize -= 1;
                RTB5.FontSize -= 1;
                RTB6.FontSize -= 1;
                RTB7.FontSize -= 1;
                RTB8.FontSize -= 1;
                RTB9.FontSize -= 1;
            }
		}

        private void img_table_antibiotic_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Image localImage = sender as Image;
            String path = localImage.Tag as String;
            whiteGrid.Visibility = Visibility.Visible;

            BGCanvas.Source = new BitmapImage(new Uri(path,UriKind.Relative));

        }

        private void PopCloseButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            whiteGrid.Visibility = Visibility.Collapsed;
            //PopScrollIntro.Visibility = Visibility.Collapsed;
            
        }
	
    }
}