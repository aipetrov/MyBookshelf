﻿#pragma checksum "..\..\ProfilePage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "A0B1836A24071F8D3E512E06482180E5F243EE6A"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MyBookshelf;
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


namespace MyBookshelf {
    
    
    /// <summary>
    /// ProfilePage
    /// </summary>
    public partial class ProfilePage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 34 "..\..\ProfilePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock user_name;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\ProfilePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button edit_profile;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\ProfilePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox listbox_read;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\ProfilePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox listbox_recommend;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\ProfilePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button all_books;
        
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
            System.Uri resourceLocater = new System.Uri("/MyBookshelf;component/profilepage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ProfilePage.xaml"
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
            this.user_name = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.edit_profile = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\ProfilePage.xaml"
            this.edit_profile.Click += new System.Windows.RoutedEventHandler(this.edit_profile_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.listbox_read = ((System.Windows.Controls.ListBox)(target));
            
            #line 39 "..\..\ProfilePage.xaml"
            this.listbox_read.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.listbox_read_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.listbox_recommend = ((System.Windows.Controls.ListBox)(target));
            
            #line 73 "..\..\ProfilePage.xaml"
            this.listbox_recommend.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.listbox_read_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.all_books = ((System.Windows.Controls.Button)(target));
            
            #line 106 "..\..\ProfilePage.xaml"
            this.all_books.Click += new System.Windows.RoutedEventHandler(this.all_books_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 107 "..\..\ProfilePage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

