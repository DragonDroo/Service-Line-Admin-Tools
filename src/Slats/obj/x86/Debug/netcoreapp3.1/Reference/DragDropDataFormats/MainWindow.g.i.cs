﻿#pragma checksum "..\..\..\..\..\..\Reference\DragDropDataFormats\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9526E399BB99125C8991BFF391DEA582D5298B49"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DragDropDataFormats;
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


namespace DragDropDataFormats {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\..\..\..\Reference\DragDropDataFormats\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btClear;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\..\..\Reference\DragDropDataFormats\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cbAutoConvert;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\..\..\Reference\DragDropDataFormats\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock lblEventSelectionTitle;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\..\..\Reference\DragDropDataFormats\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbDropTarget;
        
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
            System.Uri resourceLocater = new System.Uri("/Slats;component/reference/dragdropdataformats/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\Reference\DragDropDataFormats\MainWindow.xaml"
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
            this.btClear = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\..\..\..\Reference\DragDropDataFormats\MainWindow.xaml"
            this.btClear.Click += new System.Windows.RoutedEventHandler(this.ClickClear);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cbAutoConvert = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 3:
            this.lblEventSelectionTitle = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.tbDropTarget = ((System.Windows.Controls.TextBox)(target));
            
            #line 48 "..\..\..\..\..\..\Reference\DragDropDataFormats\MainWindow.xaml"
            this.tbDropTarget.PreviewDrop += new System.Windows.DragEventHandler(this.EhPreviewDrop);
            
            #line default
            #line hidden
            
            #line 49 "..\..\..\..\..\..\Reference\DragDropDataFormats\MainWindow.xaml"
            this.tbDropTarget.DragEnter += new System.Windows.DragEventHandler(this.EhDragEnter);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

