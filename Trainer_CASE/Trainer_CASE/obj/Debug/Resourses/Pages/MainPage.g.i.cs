﻿#pragma checksum "..\..\..\..\Resourses\Pages\MainPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "16675C72191CE764673D1E694AFC61DC6317ED9B8E0F057F56FB61BDD3B96C60"
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
using Trainer_CASE.Resourses.Pages;


namespace Trainer_CASE.Resourses.Pages {
    
    
    /// <summary>
    /// MainPage
    /// </summary>
    public partial class MainPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 133 "..\..\..\..\Resourses\Pages\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEASY;
        
        #line default
        #line hidden
        
        
        #line 156 "..\..\..\..\Resourses\Pages\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnMEDIUM;
        
        #line default
        #line hidden
        
        
        #line 178 "..\..\..\..\Resourses\Pages\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnHARD;
        
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
            System.Uri resourceLocater = new System.Uri("/Trainer_CASE;component/resourses/pages/mainpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Resourses\Pages\MainPage.xaml"
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
            this.btnEASY = ((System.Windows.Controls.Button)(target));
            
            #line 133 "..\..\..\..\Resourses\Pages\MainPage.xaml"
            this.btnEASY.Click += new System.Windows.RoutedEventHandler(this.btnEASY_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnMEDIUM = ((System.Windows.Controls.Button)(target));
            
            #line 156 "..\..\..\..\Resourses\Pages\MainPage.xaml"
            this.btnMEDIUM.Click += new System.Windows.RoutedEventHandler(this.btnMEDIUM_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnHARD = ((System.Windows.Controls.Button)(target));
            
            #line 178 "..\..\..\..\Resourses\Pages\MainPage.xaml"
            this.btnHARD.Click += new System.Windows.RoutedEventHandler(this.btnHARD_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

