﻿#pragma checksum "..\..\..\..\..\..\Reference\DragDropThumbOps\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "CCC516B2F67A3996394B3421ADF1B203FF7CCF5A"
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
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace DragDropThumbOps {
    
    
    /// <summary>
    /// Pane
    /// </summary>
    public partial class Pane : System.Windows.Controls.Canvas, System.Windows.Markup.IComponentConnector {
        
        
        #line 6 "..\..\..\..\..\..\Reference\DragDropThumbOps\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas myCanvasStretch;
        
        #line default
        #line hidden
        
        
        #line 7 "..\..\..\..\..\..\Reference\DragDropThumbOps\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox changes;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\..\..\Reference\DragDropThumbOps\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.Thumb myThumb;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Slats;component/reference/dragdropthumbops/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\Reference\DragDropThumbOps\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.myCanvasStretch = ((System.Windows.Controls.Canvas)(target));
            return;
            case 2:
            this.changes = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.myThumb = ((System.Windows.Controls.Primitives.Thumb)(target));
            
            #line 14 "..\..\..\..\..\..\Reference\DragDropThumbOps\MainWindow.xaml"
            this.myThumb.DragDelta += new System.Windows.Controls.Primitives.DragDeltaEventHandler(this.OnDragDelta);
            
            #line default
            #line hidden
            
            #line 15 "..\..\..\..\..\..\Reference\DragDropThumbOps\MainWindow.xaml"
            this.myThumb.DragStarted += new System.Windows.Controls.Primitives.DragStartedEventHandler(this.OnDragStarted);
            
            #line default
            #line hidden
            
            #line 15 "..\..\..\..\..\..\Reference\DragDropThumbOps\MainWindow.xaml"
            this.myThumb.DragCompleted += new System.Windows.Controls.Primitives.DragCompletedEventHandler(this.OnDragCompleted);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

