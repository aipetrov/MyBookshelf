﻿#pragma checksum "..\..\InformationAboutBooksPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "CB547315190DFE4237848FAEDC73C8455EAE969A"
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
    /// InformationAboutBooksPage
    /// </summary>
    public partial class InformationAboutBooksPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 41 "..\..\InformationAboutBooksPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock text_author;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\InformationAboutBooksPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock text_booktitle;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\InformationAboutBooksPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock text_genre;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\InformationAboutBooksPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock text_rating;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\InformationAboutBooksPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image book_image;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\InformationAboutBooksPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock book_description;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\InformationAboutBooksPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button book_review;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\InformationAboutBooksPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_add;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\InformationAboutBooksPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_delete;
        
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
            System.Uri resourceLocater = new System.Uri("/MyBookshelf;component/informationaboutbookspage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\InformationAboutBooksPage.xaml"
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
            this.text_author = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.text_booktitle = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.text_genre = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.text_rating = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.book_image = ((System.Windows.Controls.Image)(target));
            return;
            case 6:
            this.book_description = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.book_review = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\InformationAboutBooksPage.xaml"
            this.book_review.Click += new System.Windows.RoutedEventHandler(this.book_review_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.button_add = ((System.Windows.Controls.Button)(target));
            return;
            case 9:
            this.button_delete = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\InformationAboutBooksPage.xaml"
            this.button_delete.Click += new System.Windows.RoutedEventHandler(this.button_delete_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 53 "..\..\InformationAboutBooksPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
