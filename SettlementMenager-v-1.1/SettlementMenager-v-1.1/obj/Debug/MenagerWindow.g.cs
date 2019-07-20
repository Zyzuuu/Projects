﻿#pragma checksum "..\..\MenagerWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "873BBFBF3A2D9C6913FCB7AF4B2F7EBFE1E5461E07E4A708D7DE9664025E09DD"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

using LocalDatabaseApplication;
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


namespace LocalDatabaseApplication {
    
    
    /// <summary>
    /// MenagerWindow
    /// </summary>
    public partial class MenagerWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\MenagerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid agentDocument;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\MenagerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid importedDocument;
        
        #line default
        #line hidden
        
        
        #line 172 "..\..\MenagerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock userNameField;
        
        #line default
        #line hidden
        
        
        #line 178 "..\..\MenagerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox pathFile;
        
        #line default
        #line hidden
        
        
        #line 179 "..\..\MenagerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button openFile;
        
        #line default
        #line hidden
        
        
        #line 192 "..\..\MenagerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox atLoggedUser;
        
        #line default
        #line hidden
        
        
        #line 194 "..\..\MenagerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox allDocuments;
        
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
            System.Uri resourceLocater = new System.Uri("/SettlementMenager-v-1.1;component/menagerwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MenagerWindow.xaml"
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
            
            #line 16 "..\..\MenagerWindow.xaml"
            ((LocalDatabaseApplication.MenagerWindow)(target)).PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.DeleteItemFromDatabaseByDeleteKeyPress);
            
            #line default
            #line hidden
            return;
            case 2:
            this.agentDocument = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.importedDocument = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 4:
            
            #line 156 "..\..\MenagerWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddInsuranceDocumentButton);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 158 "..\..\MenagerWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.RemovInsuranceDocumentButton);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 160 "..\..\MenagerWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.EditInsuranceDocumentButton);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 162 "..\..\MenagerWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SearchPolicyButton);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 164 "..\..\MenagerWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ImportButton);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 166 "..\..\MenagerWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.NotSettledPolicysButton);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 168 "..\..\MenagerWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.RefreshUserDatagridButton);
            
            #line default
            #line hidden
            return;
            case 11:
            this.userNameField = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 12:
            this.pathFile = ((System.Windows.Controls.TextBox)(target));
            return;
            case 13:
            this.openFile = ((System.Windows.Controls.Button)(target));
            
            #line 179 "..\..\MenagerWindow.xaml"
            this.openFile.Click += new System.Windows.RoutedEventHandler(this.OpenFileButton);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 181 "..\..\MenagerWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.GenerateSettlementButton);
            
            #line default
            #line hidden
            return;
            case 15:
            this.atLoggedUser = ((System.Windows.Controls.CheckBox)(target));
            
            #line 192 "..\..\MenagerWindow.xaml"
            this.atLoggedUser.Checked += new System.Windows.RoutedEventHandler(this.atLoggedUser_Checked);
            
            #line default
            #line hidden
            return;
            case 16:
            this.allDocuments = ((System.Windows.Controls.CheckBox)(target));
            
            #line 194 "..\..\MenagerWindow.xaml"
            this.allDocuments.Checked += new System.Windows.RoutedEventHandler(this.allDocuments_Checked);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

