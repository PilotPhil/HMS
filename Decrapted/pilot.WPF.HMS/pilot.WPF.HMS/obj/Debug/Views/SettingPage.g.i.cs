﻿#pragma checksum "..\..\..\Views\SettingPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2B0641F2B6D74CCDFA1D9914B345B1A0CB6838CE65D4E8B12C8DF884336EAC3E"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
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
using pilot.WPF.HMS.Views;


namespace pilot.WPF.HMS.Views {
    
    
    /// <summary>
    /// SettingPage
    /// </summary>
    public partial class SettingPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 66 "..\..\..\Views\SettingPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Port;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\Views\SettingPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox BaudRate;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\Views\SettingPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox DataBit;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\Views\SettingPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Parity;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\..\Views\SettingPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox StopBit;
        
        #line default
        #line hidden
        
        
        #line 112 "..\..\..\Views\SettingPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox SelfIp;
        
        #line default
        #line hidden
        
        
        #line 121 "..\..\..\Views\SettingPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox SelfPort;
        
        #line default
        #line hidden
        
        
        #line 130 "..\..\..\Views\SettingPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ObjIp;
        
        #line default
        #line hidden
        
        
        #line 139 "..\..\..\Views\SettingPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ObjPort;
        
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
            System.Uri resourceLocater = new System.Uri("/pilot.WPF.HMS;component/views/settingpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\SettingPage.xaml"
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
            this.Port = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.BaudRate = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.DataBit = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.Parity = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.StopBit = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.SelfIp = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.SelfPort = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.ObjIp = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 9:
            this.ObjPort = ((System.Windows.Controls.ComboBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

