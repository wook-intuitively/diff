﻿#pragma checksum "..\..\..\..\Views\DiffViewer.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "AF7F7DD9D1C43ED4DCE2A7067B71B2F0C807F419"
//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 도구를 사용하여 생성되었습니다.
//     런타임 버전:4.0.30319.42000
//
//     파일 내용을 변경하면 잘못된 동작이 발생할 수 있으며, 코드를 다시 생성하면
//     이러한 변경 내용이 손실됩니다.
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
using diffTest.Views;


namespace diffTest.Views {
    
    
    /// <summary>
    /// DiffViewer
    /// </summary>
    public partial class DiffViewer : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\..\Views\DiffViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RowDefinition HeaderRow;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\..\Views\DiffViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RowDefinition ContentRow;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\..\Views\DiffViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ColumnDefinition LeftColumn;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\Views\DiffViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ColumnDefinition RightColumn;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\Views\DiffViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border HeaderBorder;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\Views\DiffViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContextMenu HeaderContextMenu;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\Views\DiffViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem InlineModeToggle;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\Views\DiffViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem SideBySideModeToggle;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\Views\DiffViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem CollapseUnchangedSectionsToggle;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\Views\DiffViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem ContextLinesMenuItems;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\Views\DiffViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem CustomizedContextLineMenuItem;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\Views\DiffViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock InlineHeaderText;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\Views\DiffViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal diffTest.Views.InternalLinesViewer InlineContentPanel;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\Views\DiffViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock LeftHeaderText;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\Views\DiffViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal diffTest.Views.InternalLinesViewer LeftContentPanel;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\Views\DiffViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GridSplitter Splitter;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\Views\DiffViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock RightHeaderText;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\Views\DiffViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal diffTest.Views.InternalLinesViewer RightContentPanel;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.6.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/diffTest;component/views/diffviewer.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\DiffViewer.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.6.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.6.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.HeaderRow = ((System.Windows.Controls.RowDefinition)(target));
            return;
            case 2:
            this.ContentRow = ((System.Windows.Controls.RowDefinition)(target));
            return;
            case 3:
            this.LeftColumn = ((System.Windows.Controls.ColumnDefinition)(target));
            return;
            case 4:
            this.RightColumn = ((System.Windows.Controls.ColumnDefinition)(target));
            return;
            case 5:
            this.HeaderBorder = ((System.Windows.Controls.Border)(target));
            return;
            case 6:
            this.HeaderContextMenu = ((System.Windows.Controls.ContextMenu)(target));
            return;
            case 7:
            this.InlineModeToggle = ((System.Windows.Controls.MenuItem)(target));
            
            #line 21 "..\..\..\..\Views\DiffViewer.xaml"
            this.InlineModeToggle.Click += new System.Windows.RoutedEventHandler(this.InlineModeToggle_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.SideBySideModeToggle = ((System.Windows.Controls.MenuItem)(target));
            
            #line 22 "..\..\..\..\Views\DiffViewer.xaml"
            this.SideBySideModeToggle.Click += new System.Windows.RoutedEventHandler(this.SideBySideModeToggle_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.CollapseUnchangedSectionsToggle = ((System.Windows.Controls.MenuItem)(target));
            
            #line 24 "..\..\..\..\Views\DiffViewer.xaml"
            this.CollapseUnchangedSectionsToggle.Click += new System.Windows.RoutedEventHandler(this.CollapseUnchangedSectionsToggle_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.ContextLinesMenuItems = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 11:
            
            #line 26 "..\..\..\..\Views\DiffViewer.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.ContextLineMenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 27 "..\..\..\..\Views\DiffViewer.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.ContextLineMenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 28 "..\..\..\..\Views\DiffViewer.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.ContextLineMenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 29 "..\..\..\..\Views\DiffViewer.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.ContextLineMenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 30 "..\..\..\..\Views\DiffViewer.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.ContextLineMenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 16:
            
            #line 31 "..\..\..\..\Views\DiffViewer.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.ContextLineMenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 17:
            
            #line 32 "..\..\..\..\Views\DiffViewer.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.ContextLineMenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 18:
            
            #line 33 "..\..\..\..\Views\DiffViewer.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.ContextLineMenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 19:
            
            #line 34 "..\..\..\..\Views\DiffViewer.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.ContextLineMenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 20:
            
            #line 35 "..\..\..\..\Views\DiffViewer.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.ContextLineMenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 21:
            this.CustomizedContextLineMenuItem = ((System.Windows.Controls.MenuItem)(target));
            
            #line 36 "..\..\..\..\Views\DiffViewer.xaml"
            this.CustomizedContextLineMenuItem.Click += new System.Windows.RoutedEventHandler(this.ContextLineMenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 22:
            this.InlineHeaderText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 23:
            this.InlineContentPanel = ((diffTest.Views.InternalLinesViewer)(target));
            return;
            case 24:
            this.LeftHeaderText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 25:
            this.LeftContentPanel = ((diffTest.Views.InternalLinesViewer)(target));
            return;
            case 26:
            this.Splitter = ((System.Windows.Controls.GridSplitter)(target));
            return;
            case 27:
            this.RightHeaderText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 28:
            this.RightContentPanel = ((diffTest.Views.InternalLinesViewer)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

