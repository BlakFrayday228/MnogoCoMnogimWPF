﻿#pragma checksum "..\..\..\Pages\KorzinaPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3E4FBFE0030BF652304DBEBE855877BC1A9E8FA38775FF0D583402452F322381"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MnogoCoMnogim.Pages;
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


namespace MnogoCoMnogim.Pages {
    
    
    /// <summary>
    /// KorzinaPage
    /// </summary>
    public partial class KorzinaPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\Pages\KorzinaPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CBNameOrder;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Pages\KorzinaPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BAdd;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Pages\KorzinaPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BAddOrder;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Pages\KorzinaPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DGOrder;
        
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
            System.Uri resourceLocater = new System.Uri("/MnogoCoMnogim;component/pages/korzinapage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\KorzinaPage.xaml"
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
            this.CBNameOrder = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.BAdd = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\Pages\KorzinaPage.xaml"
            this.BAdd.Click += new System.Windows.RoutedEventHandler(this.BAdd_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BAddOrder = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\Pages\KorzinaPage.xaml"
            this.BAddOrder.Click += new System.Windows.RoutedEventHandler(this.BAddOrder_Click_1);
            
            #line default
            #line hidden
            return;
            case 4:
            this.DGOrder = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

