#pragma checksum "..\..\WinAddDataBase.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "CDFF471B4DD1E678663F1D9C3112F7F706A6537A167D333CA95E67B0DE06630A"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using System.Windows.Shell;
using v3_languageSchool;


namespace v3_languageSchool {
    
    
    /// <summary>
    /// WinAddDataBase
    /// </summary>
    public partial class WinAddDataBase : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 41 "..\..\WinAddDataBase.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker DateAdd;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\WinAddDataBase.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SecondName;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\WinAddDataBase.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameAdd;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\WinAddDataBase.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MiddleNameAdd;
        
        #line default
        #line hidden
        
        
        #line 123 "..\..\WinAddDataBase.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox GenderAdd;
        
        #line default
        #line hidden
        
        
        #line 140 "..\..\WinAddDataBase.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PhoneAdd;
        
        #line default
        #line hidden
        
        
        #line 153 "..\..\WinAddDataBase.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox EmailAdd;
        
        #line default
        #line hidden
        
        
        #line 165 "..\..\WinAddDataBase.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox IDClientNew;
        
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
            System.Uri resourceLocater = new System.Uri("/v3 languageSchool;component/winadddatabase.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\WinAddDataBase.xaml"
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
            this.DateAdd = ((System.Windows.Controls.DatePicker)(target));
            
            #line 40 "..\..\WinAddDataBase.xaml"
            this.DateAdd.SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.DateAdd_SelectedDateChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 62 "..\..\WinAddDataBase.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.MainWin);
            
            #line default
            #line hidden
            return;
            case 3:
            this.SecondName = ((System.Windows.Controls.TextBox)(target));
            
            #line 76 "..\..\WinAddDataBase.xaml"
            this.SecondName.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.SecondName_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.NameAdd = ((System.Windows.Controls.TextBox)(target));
            
            #line 91 "..\..\WinAddDataBase.xaml"
            this.NameAdd.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.NameAdd_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 5:
            this.MiddleNameAdd = ((System.Windows.Controls.TextBox)(target));
            
            #line 106 "..\..\WinAddDataBase.xaml"
            this.MiddleNameAdd.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.MiddleNameAdd_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 6:
            this.GenderAdd = ((System.Windows.Controls.TextBox)(target));
            
            #line 122 "..\..\WinAddDataBase.xaml"
            this.GenderAdd.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.GenderAdd_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 7:
            this.PhoneAdd = ((System.Windows.Controls.TextBox)(target));
            
            #line 138 "..\..\WinAddDataBase.xaml"
            this.PhoneAdd.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.PhoneAdd_MouseDoubleClick);
            
            #line default
            #line hidden
            
            #line 139 "..\..\WinAddDataBase.xaml"
            this.PhoneAdd.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.PhoneAdd_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 8:
            this.EmailAdd = ((System.Windows.Controls.TextBox)(target));
            
            #line 152 "..\..\WinAddDataBase.xaml"
            this.EmailAdd.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.EmailAdd_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 9:
            this.IDClientNew = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            
            #line 172 "..\..\WinAddDataBase.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddingDataButton);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

