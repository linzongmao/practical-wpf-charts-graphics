﻿#pragma checksum "..\..\StemControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "DBF1A8B2AE25CD4870847ECEB5490465"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3074
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


namespace Specialized2DChartControl {
    
    
    /// <summary>
    /// StemControl
    /// </summary>
    public partial class StemControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 5 "..\..\StemControl.xaml"
        internal System.Windows.Controls.Grid grid1;
        
        #line default
        #line hidden
        
        
        #line 8 "..\..\StemControl.xaml"
        internal System.Windows.Controls.ColumnDefinition column1;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\StemControl.xaml"
        internal System.Windows.Controls.RowDefinition row1;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\StemControl.xaml"
        internal System.Windows.Controls.TextBlock tbTitle;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\StemControl.xaml"
        internal System.Windows.Controls.TextBlock tbXLabel;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\StemControl.xaml"
        internal System.Windows.Controls.TextBlock tbYLabel;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\StemControl.xaml"
        internal System.Windows.Controls.Grid chartGrid;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\StemControl.xaml"
        internal System.Windows.Controls.Canvas textCanvas;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\StemControl.xaml"
        internal System.Windows.Controls.Canvas chartCanvas;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\StemControl.xaml"
        internal System.Windows.Controls.Canvas legendCanvas;
        
        #line default
        #line hidden
        
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
            System.Uri resourceLocater = new System.Uri("/Specialized2DChartControl;component/stemcontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\StemControl.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.grid1 = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.column1 = ((System.Windows.Controls.ColumnDefinition)(target));
            return;
            case 3:
            this.row1 = ((System.Windows.Controls.RowDefinition)(target));
            return;
            case 4:
            this.tbTitle = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.tbXLabel = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.tbYLabel = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.chartGrid = ((System.Windows.Controls.Grid)(target));
            
            #line 34 "..\..\StemControl.xaml"
            this.chartGrid.SizeChanged += new System.Windows.SizeChangedEventHandler(this.chartGrid_SizeChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.textCanvas = ((System.Windows.Controls.Canvas)(target));
            return;
            case 9:
            this.chartCanvas = ((System.Windows.Controls.Canvas)(target));
            return;
            case 10:
            this.legendCanvas = ((System.Windows.Controls.Canvas)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
