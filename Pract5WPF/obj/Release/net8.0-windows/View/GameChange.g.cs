﻿#pragma checksum "..\..\..\..\View\GameChange.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "A0CF405EFCC17BD51B8E64DEFA68E6C54ADEED13"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Pract5WPF.View;
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


namespace Pract5WPF.View {
    
    
    /// <summary>
    /// GameChange
    /// </summary>
    public partial class GameChange : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\..\..\View\GameChange.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock start_message;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\View\GameChange.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock name_of_first_game;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\..\View\GameChange.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock name_of_second_game;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\..\View\GameChange.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button first_game_button;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\..\View\GameChange.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button second_game_button;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\..\View\GameChange.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button exit;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\..\..\View\GameChange.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock login;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\..\..\View\GameChange.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock balance;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Pract5WPF;component/view/gamechange.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\GameChange.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.start_message = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.name_of_first_game = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.name_of_second_game = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.first_game_button = ((System.Windows.Controls.Button)(target));
            
            #line 70 "..\..\..\..\View\GameChange.xaml"
            this.first_game_button.Click += new System.Windows.RoutedEventHandler(this.first_game_button_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.second_game_button = ((System.Windows.Controls.Button)(target));
            
            #line 77 "..\..\..\..\View\GameChange.xaml"
            this.second_game_button.Click += new System.Windows.RoutedEventHandler(this.second_game_button_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.exit = ((System.Windows.Controls.Button)(target));
            
            #line 88 "..\..\..\..\View\GameChange.xaml"
            this.exit.Click += new System.Windows.RoutedEventHandler(this.exit_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.login = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.balance = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

