// Updated by XamlIntelliSenseFileGenerator 4/27/2023 10:54:22 AM
#pragma checksum "..\..\LogInPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "BF956C292BD24F238473C0CDD3242D58B8EFD3B22DAB50EC9D5EDC00BA92ED1C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Final_Project_Informatics;
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


namespace Final_Project_Informatics
{


    /// <summary>
    /// LogInPage
    /// </summary>
    public partial class LogInPage : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {


#line 21 "..\..\LogInPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox usernametxt;

#line default
#line hidden


#line 23 "..\..\LogInPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox passwordtxt;

#line default
#line hidden


#line 25 "..\..\LogInPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RegisterButton;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Final Project Informatics;component/loginpage.xaml", System.UriKind.Relative);

#line 1 "..\..\LogInPage.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.usernametxt = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 2:
                    this.passwordtxt = ((System.Windows.Controls.PasswordBox)(target));
                    return;
                case 3:
                    this.RegisterButton = ((System.Windows.Controls.Button)(target));

#line 25 "..\..\LogInPage.xaml"
                    this.RegisterButton.Click += new System.Windows.RoutedEventHandler(this.RegisterButton_Click);

#line default
#line hidden
                    return;
                case 4:
                    this.LogInPageButton = ((System.Windows.Controls.Button)(target));

#line 26 "..\..\LogInPage.xaml"
                    this.LogInPageButton.Click += new System.Windows.RoutedEventHandler(this.LogInPageButton_Click);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.Button SignUpPageButton;
    }
}
