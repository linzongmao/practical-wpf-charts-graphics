﻿#pragma checksum "..\..\ScaleTransformation.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "CB942FA839CA8EF2FDC9602973E4A0CF"
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


namespace Transformation3D {
    
    
    /// <summary>
    /// ScaleTransformation
    /// </summary>
    public partial class ScaleTransformation : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 33 "..\..\ScaleTransformation.xaml"
        internal System.Windows.Controls.RadioButton rbOrthographic;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\ScaleTransformation.xaml"
        internal System.Windows.Controls.RadioButton rbPerspective;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\ScaleTransformation.xaml"
        internal System.Windows.Controls.TextBox tbScaleX;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\ScaleTransformation.xaml"
        internal System.Windows.Controls.TextBox tbScaleY;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\ScaleTransformation.xaml"
        internal System.Windows.Controls.TextBox tbScaleZ;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\ScaleTransformation.xaml"
        internal System.Windows.Controls.TextBox tbScaleCenter;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\ScaleTransformation.xaml"
        internal System.Windows.Controls.Button btnApply;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\ScaleTransformation.xaml"
        internal System.Windows.Controls.Viewport3D myViewport;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\ScaleTransformation.xaml"
        internal System.Windows.Media.Media3D.MatrixCamera myCameraMatrix;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\ScaleTransformation.xaml"
        internal System.Windows.Media.Media3D.ScaleTransform3D myTransform;
        
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
            System.Uri resourceLocater = new System.Uri("/Transformation3D;component/scaletransformation.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ScaleTransformation.xaml"
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
            this.rbOrthographic = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 2:
            this.rbPerspective = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 3:
            this.tbScaleX = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.tbScaleY = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.tbScaleZ = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.tbScaleCenter = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.btnApply = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\ScaleTransformation.xaml"
            this.btnApply.Click += new System.Windows.RoutedEventHandler(this.btnApply_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.myViewport = ((System.Windows.Controls.Viewport3D)(target));
            return;
            case 9:
            this.myCameraMatrix = ((System.Windows.Media.Media3D.MatrixCamera)(target));
            return;
            case 10:
            this.myTransform = ((System.Windows.Media.Media3D.ScaleTransform3D)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
