﻿#pragma checksum "..\..\..\Views\Main.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "66490DB82D2233539904CEBF70CC429E02EF9662D65848D5CEB656B671DE9F57"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ProjektSemBiblioteka;
using ProjektSemBiblioteka.ViewModels;
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
        
        
        #line 29 "..\..\..\Views\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Autor;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Views\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Literatura;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\Views\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Uzytkownicy;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\Views\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Wydawnictwa;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\..\Views\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button WypozyczonaLiteratura;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\..\Views\Main.xaml"
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
            
            #line 30 "..\..\..\Views\Main.xaml"
            this.Autor.Click += new System.Windows.RoutedEventHandler(this.AutorShow);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Literatura = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\..\Views\Main.xaml"
            this.Literatura.Click += new System.Windows.RoutedEventHandler(this.LiteraturaShow);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Uzytkownicy = ((System.Windows.Controls.Button)(target));
            
            #line 58 "..\..\..\Views\Main.xaml"
            this.Uzytkownicy.Click += new System.Windows.RoutedEventHandler(this.UzytkownicyShow);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Wydawnictwa = ((System.Windows.Controls.Button)(target));
            
            #line 72 "..\..\..\Views\Main.xaml"
            this.Wydawnictwa.Click += new System.Windows.RoutedEventHandler(this.WydawnictwoShow);
            
            #line default
            #line hidden
            return;
            case 5:
            this.WypozyczonaLiteratura = ((System.Windows.Controls.Button)(target));
            
            #line 86 "..\..\..\Views\Main.xaml"
            this.WypozyczonaLiteratura.Click += new System.Windows.RoutedEventHandler(this.WypozyczonaShow);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ZwroconaLiteratura = ((System.Windows.Controls.Button)(target));
            
            #line 100 "..\..\..\Views\Main.xaml"
            this.ZwroconaLiteratura.Click += new System.Windows.RoutedEventHandler(this.ZwrotShow);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

