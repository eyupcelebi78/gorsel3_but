﻿#pragma checksum "..\..\..\PageScreens\rezyap.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "95073F0FDABD3AEA463E1881FFCC9762E43A9609"
//------------------------------------------------------------------------------
// <auto-generated>
//     Bu kod araç tarafından oluşturuldu.
//     Çalışma Zamanı Sürümü:4.0.30319.42000
//
//     Bu dosyada yapılacak değişiklikler yanlış davranışa neden olabilir ve
//     kod yeniden oluşturulursa kaybolur.
// </auto-generated>
//------------------------------------------------------------------------------

using Halı_Saha_Yönetim.PageScreens;
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


namespace Halı_Saha_Yönetim.PageScreens {
    
    
    /// <summary>
    /// ReservationAttempt
    /// </summary>
    public partial class ReservationAttempt : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\..\PageScreens\rezyap.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbSaat;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\PageScreens\rezyap.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbSaha;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\PageScreens\rezyap.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox note;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\PageScreens\rezyap.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSaveResAttempt;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\PageScreens\rezyap.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label sahaadi;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\PageScreens\rezyap.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label sahafiyat;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\PageScreens\rezyap.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label sahakapasite;
        
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
            System.Uri resourceLocater = new System.Uri("/Halı Saha Yönetim;component/pagescreens/rezyap.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\PageScreens\rezyap.xaml"
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
            this.cmbSaat = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.cmbSaha = ((System.Windows.Controls.ComboBox)(target));
            
            #line 36 "..\..\..\PageScreens\rezyap.xaml"
            this.cmbSaha.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CmbSaha_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.note = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.btnSaveResAttempt = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\..\PageScreens\rezyap.xaml"
            this.btnSaveResAttempt.Click += new System.Windows.RoutedEventHandler(this.BtnSaveResAttempt_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 44 "..\..\..\PageScreens\rezyap.xaml"
            ((System.Windows.Controls.DatePicker)(target)).SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.Tarih_SelectedDateChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.sahaadi = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.sahafiyat = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.sahakapasite = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

