﻿#pragma checksum "..\..\MatrixTransformation.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "93F75D693D9AA7801FBE9ED2C7B4ECFD"
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
    /// MatrixTransformation
    /// </summary>
    public partial class MatrixTransformation : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 60 "..\..\MatrixTransformation.xaml"
        internal System.Windows.Controls.TextBox tbM11;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\MatrixTransformation.xaml"
        internal System.Windows.Controls.TextBox tbM21;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\MatrixTransformation.xaml"
        internal System.Windows.Controls.TextBox tbM31;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\MatrixTransformation.xaml"
        internal System.Windows.Controls.TextBox tbM41;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\MatrixTransformation.xaml"
        internal System.Windows.Controls.TextBox tbM12;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\MatrixTransformation.xaml"
        internal System.Windows.Controls.TextBox tbM22;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\MatrixTransformation.xaml"
        internal System.Windows.Controls.TextBox tbM32;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\MatrixTransformation.xaml"
        internal System.Windows.Controls.TextBox tbM42;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\MatrixTransformation.xaml"
        internal System.Windows.Controls.TextBox tbM13;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\MatrixTransformation.xaml"
        internal System.Windows.Controls.TextBox tbM23;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\MatrixTransformation.xaml"
        internal System.Windows.Controls.TextBox tbM33;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\MatrixTransformation.xaml"
        internal System.Windows.Controls.TextBox tbM43;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\MatrixTransformation.xaml"
        internal System.Windows.Controls.TextBox tbM14;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\MatrixTransformation.xaml"
        internal System.Windows.Controls.TextBox tbM24;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\MatrixTransformation.xaml"
        internal System.Windows.Controls.TextBox tbM34;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\MatrixTransformation.xaml"
        internal System.Windows.Controls.TextBox tbM44;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\MatrixTransformation.xaml"
        internal System.Windows.Controls.RadioButton rbOrthographic;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\MatrixTransformation.xaml"
        internal System.Windows.Controls.RadioButton rbPerspective;
        
        #line default
        #line hidden
        
        
        #line 110 "..\..\MatrixTransformation.xaml"
        internal System.Windows.Controls.Button btnApply;
        
        #line default
        #line hidden
        
        
        #line 117 "..\..\MatrixTransformation.xaml"
        internal System.Windows.Controls.Viewport3D myViewport;
        
        #line default
        #line hidden
        
        
        #line 119 "..\..\MatrixTransformation.xaml"
        internal System.Windows.Media.Media3D.MatrixCamera myCameraMatrix;
        
        #line default
        #line hidden
        
        
        #line 130 "..\..\MatrixTransformation.xaml"
        internal System.Windows.Media.Media3D.MatrixTransform3D myTransform;
        
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
            System.Uri resourceLocater = new System.Uri("/Transformation3D;component/matrixtransformation.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MatrixTransformation.xaml"
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
            this.tbM11 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.tbM21 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.tbM31 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.tbM41 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.tbM12 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.tbM22 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.tbM32 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.tbM42 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.tbM13 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.tbM23 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.tbM33 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            this.tbM43 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 13:
            this.tbM14 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 14:
            this.tbM24 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 15:
            this.tbM34 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 16:
            this.tbM44 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 17:
            this.rbOrthographic = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 18:
            this.rbPerspective = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 19:
            this.btnApply = ((System.Windows.Controls.Button)(target));
            
            #line 112 "..\..\MatrixTransformation.xaml"
            this.btnApply.Click += new System.Windows.RoutedEventHandler(this.btnApply_Click);
            
            #line default
            #line hidden
            return;
            case 20:
            this.myViewport = ((System.Windows.Controls.Viewport3D)(target));
            return;
            case 21:
            this.myCameraMatrix = ((System.Windows.Media.Media3D.MatrixCamera)(target));
            return;
            case 22:
            this.myTransform = ((System.Windows.Media.Media3D.MatrixTransform3D)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
