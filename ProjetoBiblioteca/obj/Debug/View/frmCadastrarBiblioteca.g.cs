﻿#pragma checksum "..\..\..\View\frmCadastrarBiblioteca.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "71944D93A12CB78AE101904FE21C912A"
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


namespace ProjetoBiblioteca.View {
    
    
    /// <summary>
    /// frmCadastrarBiblioteca
    /// </summary>
    public partial class frmCadastrarBiblioteca : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\View\frmCadastrarBiblioteca.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnGravar;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\View\frmCadastrarBiblioteca.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblNome;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\View\frmCadastrarBiblioteca.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblEndereco;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\View\frmCadastrarBiblioteca.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblTelefone;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\View\frmCadastrarBiblioteca.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNome;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\View\frmCadastrarBiblioteca.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtEndereco;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\View\frmCadastrarBiblioteca.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtTelefone;
        
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
            System.Uri resourceLocater = new System.Uri("/ProjetoBiblioteca;component/view/frmcadastrarbiblioteca.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\frmCadastrarBiblioteca.xaml"
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
            this.btnGravar = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\View\frmCadastrarBiblioteca.xaml"
            this.btnGravar.Click += new System.Windows.RoutedEventHandler(this.btnGravar_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.lblNome = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.lblEndereco = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.lblTelefone = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.txtNome = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txtEndereco = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.txtTelefone = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

