﻿#pragma checksum "..\..\RegisterPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F86FD65F0790C481F2538192CD2939E429ECAB002C9510CC797C2A62810332A5"
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
    /// RegisterPage
    /// </summary>
    public partial class RegisterPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\RegisterPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBox_Email;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\RegisterPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox PasswordBox_Password;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\RegisterPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox PasswordBox_Password_Confirm;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\RegisterPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_Register;
        
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
            System.Uri resourceLocater = new System.Uri("/DocuVault;component/registerpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\RegisterPage.xaml"
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
            
            #line 32 "..\..\RegisterPage.xaml"
            this.TextBox_Email.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_Email_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.PasswordBox_Password = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 56 "..\..\RegisterPage.xaml"
            this.PasswordBox_Password.PasswordChanged += new System.Windows.RoutedEventHandler(this.PasswordBox_Password_Changed);
            
            #line default
            #line hidden
            return;
            case 3:
            this.PasswordBox_Password_Confirm = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 80 "..\..\RegisterPage.xaml"
            this.PasswordBox_Password_Confirm.PasswordChanged += new System.Windows.RoutedEventHandler(this.PasswordBox_Password_Confirm_Changed);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Btn_Register = ((System.Windows.Controls.Button)(target));
            
            #line 105 "..\..\RegisterPage.xaml"
            this.Btn_Register.Click += new System.Windows.RoutedEventHandler(this.Btn_Register_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 149 "..\..\RegisterPage.xaml"
            ((System.Windows.Controls.Label)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.BackToLogin_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

