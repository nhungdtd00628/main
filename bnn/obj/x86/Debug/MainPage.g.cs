﻿#pragma checksum "C:\Users\Administrator\source\repos\bnn\bnn\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E18EAA020E8C68A3BFAEEFDCACF3B134"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace bnn
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // MainPage.xaml line 18
                {
                    this.FirstName = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 3: // MainPage.xaml line 20
                {
                    this.LastName = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 4: // MainPage.xaml line 22
                {
                    this.Email = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 5: // MainPage.xaml line 24
                {
                    this.Password = (global::Windows.UI.Xaml.Controls.PasswordBox)(target);
                }
                break;
            case 6: // MainPage.xaml line 25
                {
                    this.Gender = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 7: // MainPage.xaml line 27
                {
                    global::Windows.UI.Xaml.Controls.RadioButton element7 = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    ((global::Windows.UI.Xaml.Controls.RadioButton)element7).Checked += this.Do_checked;
                }
                break;
            case 8: // MainPage.xaml line 28
                {
                    global::Windows.UI.Xaml.Controls.RadioButton element8 = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    ((global::Windows.UI.Xaml.Controls.RadioButton)element8).Checked += this.Do_checked;
                }
                break;
            case 9: // MainPage.xaml line 29
                {
                    global::Windows.UI.Xaml.Controls.RadioButton element9 = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    ((global::Windows.UI.Xaml.Controls.RadioButton)element9).Checked += this.Do_checked;
                }
                break;
            case 10: // MainPage.xaml line 30
                {
                    global::Windows.UI.Xaml.Controls.Button element10 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element10).Click += this.Choose_Image;
                }
                break;
            case 11: // MainPage.xaml line 32
                {
                    this.Phone = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 12: // MainPage.xaml line 35
                {
                    this.Address = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 13: // MainPage.xaml line 37
                {
                    this.Introduction = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 14: // MainPage.xaml line 38
                {
                    global::Windows.UI.Xaml.Controls.Button element14 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element14).Click += this.Do_Submit;
                }
                break;
            case 15: // MainPage.xaml line 39
                {
                    global::Windows.UI.Xaml.Controls.Button element15 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element15).Click += this.doReset_Click;
                }
                break;
            case 16: // MainPage.xaml line 40
                {
                    this.AvatarURL = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 17: // MainPage.xaml line 42
                {
                    this.avatar = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 18: // MainPage.xaml line 43
                {
                    this.fristName = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 19: // MainPage.xaml line 44
                {
                    this.email = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 20: // MainPage.xaml line 45
                {
                    this.password = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 21: // MainPage.xaml line 46
                {
                    this.phone = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 22: // MainPage.xaml line 47
                {
                    this.address = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 23: // MainPage.xaml line 48
                {
                    this.lastName = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 24: // MainPage.xaml line 49
                {
                    this.LoadingIndicator = (global::Windows.UI.Xaml.Controls.ProgressRing)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

