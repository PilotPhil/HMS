﻿#pragma checksum "..\..\..\Views\ModBusGuideView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7D6073322FC4A9C26DFE7EAFE215F649F48B3C27354BC6523522496DE7527BF0"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using HandyControl.Controls;
using HandyControl.Data;
using HandyControl.Expression.Media;
using HandyControl.Expression.Shapes;
using HandyControl.Interactivity;
using HandyControl.Media.Animation;
using HandyControl.Media.Effects;
using HandyControl.Properties.Langs;
using HandyControl.Themes;
using HandyControl.Tools;
using HandyControl.Tools.Converter;
using HandyControl.Tools.Extension;
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
using pilot.SCADA.Converter;


namespace pilot.SCADA.Views {
    
    
    /// <summary>
    /// ModBusGuideView
    /// </summary>
    public partial class ModBusGuideView : HandyControl.Controls.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\Views\ModBusGuideView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal pilot.SCADA.Views.ModBusGuideView thisWindow;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\..\Views\ModBusGuideView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Port;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\..\Views\ModBusGuideView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox BaudRate;
        
        #line default
        #line hidden
        
        
        #line 111 "..\..\..\Views\ModBusGuideView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox DataBit;
        
        #line default
        #line hidden
        
        
        #line 116 "..\..\..\Views\ModBusGuideView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Parity;
        
        #line default
        #line hidden
        
        
        #line 121 "..\..\..\Views\ModBusGuideView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox StopBit;
        
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
            System.Uri resourceLocater = new System.Uri("/pilot.SCADA;component/views/modbusguideview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\ModBusGuideView.xaml"
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
            this.thisWindow = ((pilot.SCADA.Views.ModBusGuideView)(target));
            return;
            case 2:
            this.Port = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.BaudRate = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.DataBit = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.Parity = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.StopBit = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            
            #line 175 "..\..\..\Views\ModBusGuideView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Cancel_click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

