﻿#pragma checksum "..\..\..\..\..\..\Views\CPRs\CprBuilderPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "949C82D9C3625C810E89FC64A092D735A5502007"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Slats.ViewModels;
using Slats.Views;
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


namespace Slats.Views {
    
    
    /// <summary>
    /// CprBuilderPage
    /// </summary>
    public partial class CprBuilderPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 92 "..\..\..\..\..\..\Views\CPRs\CprBuilderPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnUndo;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\..\..\..\..\Views\CPRs\CprBuilderPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRedo;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\..\..\..\..\Views\CPRs\CprBuilderPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ForegroundColor;
        
        #line default
        #line hidden
        
        
        #line 117 "..\..\..\..\..\..\Views\CPRs\CprBuilderPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton btnBold;
        
        #line default
        #line hidden
        
        
        #line 124 "..\..\..\..\..\..\Views\CPRs\CprBuilderPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton btnItalic;
        
        #line default
        #line hidden
        
        
        #line 131 "..\..\..\..\..\..\Views\CPRs\CprBuilderPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton btnUnderline;
        
        #line default
        #line hidden
        
        
        #line 138 "..\..\..\..\..\..\Views\CPRs\CprBuilderPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbFontFamily;
        
        #line default
        #line hidden
        
        
        #line 142 "..\..\..\..\..\..\Views\CPRs\CprBuilderPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbFontSize;
        
        #line default
        #line hidden
        
        
        #line 150 "..\..\..\..\..\..\Views\CPRs\CprBuilderPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView argh;
        
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
            System.Uri resourceLocater = new System.Uri("/Slats;component/views/cprs/cprbuilderpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\Views\CPRs\CprBuilderPage.xaml"
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
            this.btnUndo = ((System.Windows.Controls.Button)(target));
            
            #line 97 "..\..\..\..\..\..\Views\CPRs\CprBuilderPage.xaml"
            this.btnUndo.Click += new System.Windows.RoutedEventHandler(this.btnUndo_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnRedo = ((System.Windows.Controls.Button)(target));
            
            #line 104 "..\..\..\..\..\..\Views\CPRs\CprBuilderPage.xaml"
            this.btnRedo.Click += new System.Windows.RoutedEventHandler(this.btnRedo_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ForegroundColor = ((System.Windows.Controls.Button)(target));
            
            #line 111 "..\..\..\..\..\..\Views\CPRs\CprBuilderPage.xaml"
            this.ForegroundColor.Click += new System.Windows.RoutedEventHandler(this.ForegroundColor_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnBold = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            
            #line 118 "..\..\..\..\..\..\Views\CPRs\CprBuilderPage.xaml"
            this.btnBold.Click += new System.Windows.RoutedEventHandler(this.btnBold_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnItalic = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            
            #line 125 "..\..\..\..\..\..\Views\CPRs\CprBuilderPage.xaml"
            this.btnItalic.Click += new System.Windows.RoutedEventHandler(this.btnItalic_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnUnderline = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            
            #line 133 "..\..\..\..\..\..\Views\CPRs\CprBuilderPage.xaml"
            this.btnUnderline.Click += new System.Windows.RoutedEventHandler(this.btnUnderline_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.cmbFontFamily = ((System.Windows.Controls.ComboBox)(target));
            
            #line 141 "..\..\..\..\..\..\Views\CPRs\CprBuilderPage.xaml"
            this.cmbFontFamily.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmbFontFamily_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.cmbFontSize = ((System.Windows.Controls.ComboBox)(target));
            
            #line 146 "..\..\..\..\..\..\Views\CPRs\CprBuilderPage.xaml"
            this.cmbFontSize.AddHandler(System.Windows.Controls.Primitives.TextBoxBase.TextChangedEvent, new System.Windows.Controls.TextChangedEventHandler(this.cmbFontSize_TextChanged));
            
            #line default
            #line hidden
            return;
            case 9:
            this.argh = ((System.Windows.Controls.ListView)(target));
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 10:
            
            #line 186 "..\..\..\..\..\..\Views\CPRs\CprBuilderPage.xaml"
            ((System.Windows.Controls.RichTextBox)(target)).SelectionChanged += new System.Windows.RoutedEventHandler(this.RtfBox_SelectionChanged);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

