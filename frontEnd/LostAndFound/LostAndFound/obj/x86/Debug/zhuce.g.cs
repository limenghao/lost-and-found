﻿#pragma checksum "F:\学习资料\北大软微\研一下学期\软件实现技术\LOST_AND_FOUND\project\lost-and-found\frontEnd\LostAndFound\LostAndFound\zhuce.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D713B88B8CF9D6C82DC9777E8EA1A162"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LostAndFound
{
    partial class zhuce : 
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
            case 2: // zhuce.xaml line 14
                {
                    this.username_new = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 3: // zhuce.xaml line 16
                {
                    this.password_new = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 4: // zhuce.xaml line 18
                {
                    this.phoneNo_new = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 5: // zhuce.xaml line 22
                {
                    global::Windows.UI.Xaml.Controls.Button element5 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element5).Click += this.Register_Button_Click;
                }
                break;
            case 6: // zhuce.xaml line 24
                {
                    this.checkCode_new = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 7: // zhuce.xaml line 25
                {
                    this.gender_combox = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
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

