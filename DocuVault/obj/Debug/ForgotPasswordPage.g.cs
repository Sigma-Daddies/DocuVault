﻿#pragma checksum "..\..\ForgotPasswordPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E42A12E1AFD202686924043258892DA382E97F21C0ECC8B3FA743E3DDC996D13"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DocuVault;
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


namespace DocuVault {
    
    
    /// <summary>
    /// ForgotPasswordPage
    /// </summary>
    public partial class ForgotPasswordPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 33 "..\..\ForgotPasswordPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBox_Email;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\ForgotPasswordPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBox_Code;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\ForgotPasswordPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox PasswordBox_Password;
        
        #line default
        #line hidden
        
        
        #line 117 "..\..\ForgotPasswordPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox PasswordBox_Password_Confirm;
        
        #line default
        #line hidden
        
        
        #line 142 "..\..\ForgotPasswordPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_Reset;
        
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
            System.Uri resourceLocater = new System.Uri("/DocuVault;component/forgotpasswordpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ForgotPasswordPage.xaml"
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
            this.TextBox_Email = ((System.Windows.Controls.TextBox)(target));
            
            #line 34 "..\..\ForgotPasswordPage.xaml"
            this.TextBox_Email.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_Email_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.TextBox_Code = ((System.Windows.Controls.TextBox)(target));
            
            #line 70 "..\..\ForgotPasswordPage.xaml"
            this.TextBox_Code.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_Code_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.PasswordBox_Password = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 94 "..\..\ForgotPasswordPage.xaml"
            this.PasswordBox_Password.PasswordChanged += new System.Windows.RoutedEventHandler(this.PasswordBox_Password_Changed);
            
            #line default
            #line hidden
            return;
            case 5:
            this.PasswordBox_Password_Confirm = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 118 "..\..\ForgotPasswordPage.xaml"
            this.PasswordBox_Password_Confirm.PasswordChanged += new System.Windows.RoutedEventHandler(this.PasswordBox_Password_Confirm_Changed);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Btn_Reset = ((System.Windows.Controls.Button)(target));
            
            #line 143 "..\..\ForgotPasswordPage.xaml"
            this.Btn_Reset.Click += new System.Windows.RoutedEventHandler(this.Btn_Reset_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 187 "..\..\ForgotPasswordPage.xaml"
            ((System.Windows.Controls.Label)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.BackToLogin_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 2:
            
            #line 54 "..\..\ForgotPasswordPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_EmailAction_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

