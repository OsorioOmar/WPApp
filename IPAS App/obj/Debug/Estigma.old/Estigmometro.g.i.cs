﻿#pragma checksum "D:\Usuario\Mis Documentos\GitHub\Ipas\WPApp\IPAS App\Estigma.old\Estigmometro.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "AF9060EDA8FB002143C5CC2AC3B2759B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace IPAS_App {
    
    
    public partial class Estigmometro : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal Microsoft.Phone.Controls.Panorama PanoramaView;
        
        internal Microsoft.Phone.Controls.PanoramaItem Item_Instrucciones;
        
        internal System.Windows.Controls.Grid Grid_Instrucciones;
        
        internal System.Windows.Controls.TextBlock TextBlock_Instrucciones;
        
        internal Microsoft.Phone.Controls.PanoramaItem Item_Preguntas;
        
        internal System.Windows.Controls.Grid Grid_Preguntas;
        
        internal System.Windows.Controls.TextBlock TextBlock_Preguntas;
        
        internal System.Windows.Controls.RadioButton opcionA;
        
        internal System.Windows.Controls.RadioButton opcionB;
        
        internal System.Windows.Controls.RadioButton opcionC;
        
        internal System.Windows.Controls.Button Btn_Siguiente;
        
        internal System.Windows.Controls.Button Btn_Anterior;
        
        internal Microsoft.Phone.Controls.PanoramaItem Item_Resultado;
        
        internal System.Windows.Controls.Grid Grid_Resultados;
        
        internal System.Windows.Controls.TextBlock TextBlock_Resultado;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/IPAS%20App;component/Estigma.old/Estigmometro.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.PanoramaView = ((Microsoft.Phone.Controls.Panorama)(this.FindName("PanoramaView")));
            this.Item_Instrucciones = ((Microsoft.Phone.Controls.PanoramaItem)(this.FindName("Item_Instrucciones")));
            this.Grid_Instrucciones = ((System.Windows.Controls.Grid)(this.FindName("Grid_Instrucciones")));
            this.TextBlock_Instrucciones = ((System.Windows.Controls.TextBlock)(this.FindName("TextBlock_Instrucciones")));
            this.Item_Preguntas = ((Microsoft.Phone.Controls.PanoramaItem)(this.FindName("Item_Preguntas")));
            this.Grid_Preguntas = ((System.Windows.Controls.Grid)(this.FindName("Grid_Preguntas")));
            this.TextBlock_Preguntas = ((System.Windows.Controls.TextBlock)(this.FindName("TextBlock_Preguntas")));
            this.opcionA = ((System.Windows.Controls.RadioButton)(this.FindName("opcionA")));
            this.opcionB = ((System.Windows.Controls.RadioButton)(this.FindName("opcionB")));
            this.opcionC = ((System.Windows.Controls.RadioButton)(this.FindName("opcionC")));
            this.Btn_Siguiente = ((System.Windows.Controls.Button)(this.FindName("Btn_Siguiente")));
            this.Btn_Anterior = ((System.Windows.Controls.Button)(this.FindName("Btn_Anterior")));
            this.Item_Resultado = ((Microsoft.Phone.Controls.PanoramaItem)(this.FindName("Item_Resultado")));
            this.Grid_Resultados = ((System.Windows.Controls.Grid)(this.FindName("Grid_Resultados")));
            this.TextBlock_Resultado = ((System.Windows.Controls.TextBlock)(this.FindName("TextBlock_Resultado")));
        }
    }
}

