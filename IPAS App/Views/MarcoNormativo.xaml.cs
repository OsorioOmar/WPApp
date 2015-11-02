﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Telerik.Windows.Controls.Primitives;
using Telerik.Windows.Controls;
using IPAS_App.Model;
using Microsoft.Phone.Tasks;

namespace IPAS.Views
{
    public partial class MarcoNormativo : PhoneApplicationPage
    {
        string[] preguntas_text = new string[5];
        string[] rads = new string[] { "rad1", "rad2", "rad3", "rad4" };
        RadioButton[] r = new RadioButton[4];
        List<Pregunta> preguntas = new List<Pregunta>();
        Pregunta p,p1,p2,p3,p4,p5;
        int i = 0;
        ApplicationBarIconButton bSiguiente, bPrevio, bCancelar, bTerminar;
        public MarcoNormativo()
        {
            InitializeComponent();
            c_resultado.Visibility = Visibility.Collapsed;
            n_resultado_1.Visibility = Visibility.Collapsed;
            n_resultado_2.Visibility = Visibility.Collapsed;
            n_resultado_3.Visibility = Visibility.Collapsed;
            RadPlaneProjectionAnimation obj_Animation = new RadPlaneProjectionAnimation();
            obj_Animation.AutoReverse = false;
            obj_Animation.Axes = PerspectiveAnimationAxis.XY;
            obj_Animation.StartAngleY = -450.22;
            obj_Animation.EndAngleY = 0;
            obj_Animation.Direction = PerspectiveAnimationDirection.Clockwise;
            obj_Animation.Duration = TimeSpan.FromSeconds(.7);
            obj_Animation.Ended += this.obj_Animation_Ended;

            test_window.Visibility = Visibility.Collapsed;
            ApplicationBar = new ApplicationBar();
            this.bSiguiente = new ApplicationBarIconButton();
            this.bPrevio = new ApplicationBarIconButton();
            this.bCancelar = new ApplicationBarIconButton();
            this.bTerminar = new ApplicationBarIconButton();
            ApplicationBar.Mode = ApplicationBarMode.Default;
            ApplicationBar.IsMenuEnabled = false;
            bSiguiente.IconUri = new Uri("/Assets/iconos/appbar.arrow.right.png", UriKind.Relative);
            bSiguiente.Text = "Siguiente";
            bPrevio.IconUri = new Uri("/Assets/iconos/appbar.arrow.left.png", UriKind.Relative);
            bPrevio.Text = "Anterior";
            bCancelar.IconUri = new Uri("/Assets/iconos/appbar.close.png", UriKind.Relative);
            bCancelar.Text = "Cancelar";
            bTerminar.IconUri = new Uri("/Assets/iconos/appbar.check.png", UriKind.Relative);
            bTerminar.Text = "Terminar";

            ApplicationBar.Buttons.Add(bCancelar);
            ApplicationBar.Buttons.Add(bSiguiente);


            bCancelar.Click += new EventHandler(cancel_test);
            bPrevio.Click += new EventHandler(GoToPrev);
            bSiguiente.Click += new EventHandler(GoToNext);
            bTerminar.Click += new EventHandler(GoToEnd);
            ApplicationBar.IsVisible = false;
            r[0] = r1; r[1] = r2; r[2] = r3; r[3] = r4;
            preguntas_text[0] = "Por cuál de las siguientes razones una mujer puede abortar de forma legal en cualquier estado de la República Mexicana?";
            preguntas_text[1] = "¿En qué estados de la República Mexicana el aborto es legal por razones económicas?";
            preguntas_text[2] = "¿En qué estado de la República Mexicana el aborto voluntario es legal, hasta las 12 semanas de embarazo?";
            preguntas_text[3] = "Si a tu centro de salud llegara una mujer solicitando una ILE por violación tú decidirías…";
            preguntas_text[4] = "¿Quiénes pueden negarse a practicar una interrupción legal del embarazo por argumentos morales?";


            p1 = new Pregunta(this.i, preguntas_text[this.i], "Grave daño a la salud de la mujer", "Peligro de muerte de la mujer", "Violación de la mujer", "Malformaciones en el producto", "La violación es la única causal permitida en todos los estados de la República Mexicana.  La Ley General de Víctimas establece que todas las mujeres que han sido violadas tienen derecho a abortar si así lo deciden. Se trata de un servicio de emergencia médica obligatoria que no puede condicionarse bajo ninguna circunstancia.");
            p1.correcta = p1.res3;
            this.i++;
            p2 = new Pregunta(this.i, preguntas_text[this.i], "Michoacán y Yucatán", "Oaxaca y Veracruz", "Veracruz y Distrito Federal", "Hidalgo y Estado de México", "En Michoacán y Yucatán el aborto es legal por razones económicas.  Prohibir el aborto a las mujeres que se encuentran en situación de pobreza, agrava su condición de vulnerabilidad y atenta contra sus derechos humanos.");
            p2.correcta = p2.res1;
            this.i++;
            p3 = new Pregunta(this.i, preguntas_text[this.i], "Estado de México", "Hidalgo", "Distrito Federal", "Tabasco", "Desde 2007, Interrumpir el embarazo es legal en el Distrito Federal.  Año con año miles de mujeres de distintos estados de la República acuden a los servicios públicos de salud para poder ejercer su derecho a decidir, con absoluta seguridad.");
            p3.correcta = p3.res3;
            this.i++;
            p4 = new Pregunta(this.i, preguntas_text[this.i], "Investigar primero si es verdad que la mujer fue violada para darle el servicio", "Negarte a hacer el aborto y decirle a la mujer que busque otro proveedor", "Referirla con un médico privado que conozcas", "Darle el servicio si cuentas con las habilidades para hacerlo", "El personal médico puede decidir legalmente proteger la intimidad de su usuaria. La ley reconoce que ciertos vínculos profesionales, dificultan comunicar la comisión de un delito o revelar la identidad del autor del mismo. Los proveedores de servicios de salud deben a sus usuarias confidencialidad.");
            p4.correcta = p4.res4;
            this.i++;
            p5 = new Pregunta(this.i, preguntas_text[this.i], "Todo el personal que labora en un servicio de  salud", "La institución de salud", "El  personal médico capacitado para realizarlo", "", "Con la objeción de conciencia el único que puede negarse a practicar la ILE es la/el médico, aunque éste tendría que asegurar el derecho de la mujer a recibir el servicio. La objeción de conciencia es personal, no institucional, El personal médico tiene la obligación de canalizar a otro proveedor de servicios, siempre y cuando la demora no ponga en riesgo la salud o la vida de la mujer.");
            p5.correcta = p5.res3;
            this.i = 0;
            preguntas.Add(p1); preguntas.Add(p2); preguntas.Add(p3); preguntas.Add(p4); preguntas.Add(p5);
            pregunta_textblock.Text = (this.i + 1).ToString();

            RadAnimationManager.Play(LayoutRoot, obj_Animation);

            
        }
        private void HyperlinkButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            WebBrowserTask webBrowserTask = new WebBrowserTask();
            webBrowserTask.Uri = new Uri("http://ipasmexico.org", UriKind.Absolute);
            webBrowserTask.Show();
        }
        private void GoToEnd(object sender, EventArgs e)
        {
            c_resultado.Visibility = Visibility.Collapsed;
            n_resultado_1.Visibility = Visibility.Collapsed;
            n_resultado_2.Visibility = Visibility.Collapsed;
            n_resultado_3.Visibility = Visibility.Collapsed;
            ApplicationBar.Buttons.RemoveAt(0);
            ApplicationBar.Buttons.Insert(0, bCancelar);
            ApplicationBar.Buttons.Insert(1, bSiguiente);
            ApplicationBar.IsVisible = false;
            img_holder_MarcoNtest.Visibility = Visibility.Visible;
            test_window.Visibility = Visibility.Collapsed;
            this.i = 0;
            foreach (var item in preguntas)
            {
                item.rad_checked = 0;
            }
            foreach (var item in r)
            {
                item.IsChecked = false;
            }
        }
        private void titulo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (((Pivot)sender).SelectedIndex)
            {
                case 0:
                    ApplicationBar.IsVisible = false;
                    break;

                case 1:
                    ApplicationBar.IsVisible = false;
                    break;

                case 2:
                    if (img_holder_MarcoNtest.Visibility == Visibility.Collapsed)
                    {
                        ApplicationBar.IsVisible = true;
                    }
                    else
                    {
                        ApplicationBar.IsVisible = false;
                    }
                    
                    break;

            }
        }
        
        private void GoToNext(object sender, EventArgs e)
        {
            
            //Show before Next text in a radmessagebox.
            showMessageBox(this.i);

            if (this.i >= 4) //fin del cuestionario.
            {
                //ApplicationBar.IsVisible = false;
                //img_holder_MarcoNtest.Visibility = Visibility.Visible;
                test_window.Visibility = Visibility.Collapsed;
                i = 0;
                int c = 1;
                //calcular Score.
               
                foreach (var item in preguntas)
                {
                    if (item.its_correct == true)
                    {
                        //sumar correctas
                        c++;
                    }
                    item.rad_checked = -1;
                }
                foreach (var item in r)
                {
                    item.IsChecked = false;
                }
                if (c < 3) { t_resultado.Text = ("Cuidado!!! Desconocer la normatividad puede poner en riesgo la salud de las mujeres y tu desempeño profesional"); n_resultado_2.Visibility = Visibility.Visible; }//Malo
                else
                {
                    if (c == 5) { t_resultado.Text = ("Felicidades!!!  Conoces aspectos generales de la normatividad del aborto legal en México y facilitas el acceso a las mujeres."); n_resultado_1.Visibility = Visibility.Visible; } //Perfecto
                    else { t_resultado.Text =  ("Sigue actualizando tus conocimientos sobre la normatividad y en esa medida podrás ampliar el acceso a las mujeres."); n_resultado_3.Visibility = Visibility.Visible; } //Regular
                }
                ApplicationBar.Buttons.RemoveAt(0);
                ApplicationBar.Buttons.RemoveAt(0);

                ApplicationBar.Buttons.Insert(0, bTerminar);
                c_resultado.Visibility = Visibility.Visible;
            }
            else
            {
                //save user answer.
                saveAnswer(this.i) ;
                this.i++;
                    if (this.i == 1) //segunda pregunta
                    {
                        modifyAppbar(bPrevio);
                        ActualizarRads(this.i);
                    }
                    else
                    {
                        ActualizarRads(this.i);
                    }
             }
            
        }

        private void GoToPrev(object sender, EventArgs e)
        {

                if (this.i == 1) //regresa al principio.
                {
                    saveAnswer(this.i);
                    this.i--;
                    modifyAppbar(bCancelar);
                    ActualizarRads(this.i);
                }
                else
                { saveAnswer(this.i); this.i--; ActualizarRads(this.i); }
        }

        private void cancel_test(object sender, EventArgs e)
        {
            ApplicationBar.IsVisible = false;
            img_holder_MarcoNtest.Visibility = Visibility.Visible;
            test_window.Visibility = Visibility.Collapsed;
            this.i = 0;
            foreach (var item in preguntas)
            {
                item.rad_checked = 0;
            }
            foreach (var item in r)
            {
                item.IsChecked = false;
            }
            
        }

        private void Image_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            img_holder_MarcoNtest.Visibility = Visibility.Collapsed;
            test_window.Visibility = Visibility.Visible;
            ApplicationBar.IsVisible = true;
            ActualizarRads(this.i);
            //this.i++;
           
        }

        private void ActualizarRads(int o)
        {
            p = preguntas.Find(k => k.id == o);
            pregunta_text.Text = p.text;
            r1.Content = p.res1;
            r2.Content = p.res2;
            r3.Content = p.res3;
            if (p.res4 != "")
            { r4.Content = p.res4; r4.Visibility = Visibility.Visible; }
            else
            { r4.Visibility = Visibility.Collapsed; }
            if (p.rad_checked != -1)
            {
                r[p.rad_checked].IsChecked = true;
            }
            pregunta_textblock.Text = "Pregunta "+(this.i + 1).ToString() + " de 5";
        }

        private void saveAnswer(int o)
        {
            p = preguntas.Find(k => k.id == o);
            for (int y = 0; y <= 3; y++)
            {
                if (r[y].IsChecked == true)
                {
                    p.rad_checked = y;
                    if (r[y].Content.ToString() == p.correcta)
                    {
                        p.its_correct = true;
                    }
                    r[y].IsChecked = false;
                    break;
                }
            }

        }
        private void showMessageBox(int o)
        {
            p = preguntas.Find(k => k.id == o);
            RadMessageBox.ShowAsync(p.before_next,MessageBoxButtons.OK,vibrate:false);
        }
        private void showResults(string a)
        {
            RadMessageBox.ShowAsync(a,MessageBoxButtons.OK,vibrate:true);
        }
        private void modifyAppbar(ApplicationBarIconButton a)
        {
            ApplicationBar.Buttons.RemoveAt(0);
            ApplicationBar.Buttons.Insert(0, a);
        }
        private void obj_Animation_Ended(object sender, AnimationEndedEventArgs e)
        {        
        }

    }
}