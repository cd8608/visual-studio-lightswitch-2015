﻿#pragma checksum "C:\Source2015\Source2015Ready\Chapter20\CS\ApressExtensionCS\ApressExtensionCS\ApressExtensionCS.Client\Presentation\Controls\ToggleControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "CCB074894D33B0DE1DBBA703B9239029"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace ApressExtensionCS.Presentation.Controls {
    
    
    public partial class ToggleControl : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Button ToggleButton;
        
        internal System.Windows.Controls.StackPanel ContentPanel;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/ApressExtensionCS.Client;component/Presentation/Controls/ToggleControl.xaml", System.UriKind.Relative));
            this.ToggleButton = ((System.Windows.Controls.Button)(this.FindName("ToggleButton")));
            this.ContentPanel = ((System.Windows.Controls.StackPanel)(this.FindName("ContentPanel")));
        }
    }
}

