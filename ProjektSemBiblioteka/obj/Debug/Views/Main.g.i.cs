﻿#pragma checksum "..\..\..\Views\Main.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "02C6C0E44799E17F9F8E7B4505E195F76A1C28F2387F9D517F2669FE0B0721F7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ProjektSemBiblioteka.Views;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace ProjektSemBiblioteka.Views {
    
    
    /// <summary>
    /// Main
    /// </summary>
    public partial class Main : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\..\Views\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Autor;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\Views\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Literatura;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\Views\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Uzytkownicy;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\Views\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Wydawnictwa;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\Views\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button WypozyczonaLiteratura;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\..\Views\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ZwroconaLiteratura;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ProjektSemBiblioteka;component/views/main.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\Main.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Autor = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\Views\Main.xaml"
            this.Autor.Click += new System.Windows.RoutedEventHandler(this.Show);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Literatura = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\..\Views\Main.xaml"
            this.Literatura.Click += new System.Windows.RoutedEventHandler(this.Show);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Uzytkownicy = ((System.Windows.Controls.Button)(target));
            
            #line 56 "..\..\..\Views\Main.xaml"
            this.Uzytkownicy.Click += new System.Windows.RoutedEventHandler(this.Show);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Wydawnictwa = ((System.Windows.Controls.Button)(target));
            
            #line 70 "..\..\..\Views\Main.xaml"
            this.Wydawnictwa.Click += new System.Windows.RoutedEventHandler(this.Show);
            
            #line default
            #line hidden
            return;
            case 5:
            this.WypozyczonaLiteratura = ((System.Windows.Controls.Button)(target));
            
            #line 84 "..\..\..\Views\Main.xaml"
            this.WypozyczonaLiteratura.Click += new System.Windows.RoutedEventHandler(this.Show);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ZwroconaLiteratura = ((System.Windows.Controls.Button)(target));
            
            #line 98 "..\..\..\Views\Main.xaml"
            this.ZwroconaLiteratura.Click += new System.Windows.RoutedEventHandler(this.Show);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

