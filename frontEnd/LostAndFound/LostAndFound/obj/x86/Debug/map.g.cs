﻿#pragma checksum "D:\code\vs 2017\lost-and-found\frontEnd\LostAndFound\LostAndFound\map.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BD9E1F85C32512C48FB5225B68DEF48D"
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
    partial class map : 
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
            case 2: // map.xaml line 20
                {
                    this.MapControl1 = (global::Windows.UI.Xaml.Controls.Maps.MapControl)(target);
                    ((global::Windows.UI.Xaml.Controls.Maps.MapControl)this.MapControl1).MapTapped += this.MapControl1_MapTapped;
                }
                break;
            case 3: // map.xaml line 25
                {
                    global::Windows.UI.Xaml.Controls.Button element3 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element3).Click += this.Button_Click;
                }
                break;
            case 4: // map.xaml line 27
                {
                    this.fabu1_button = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.fabu1_button).Tapped += this.fabu1_button_Tapped;
                }
                break;
            case 5: // map.xaml line 28
                {
                    this.text_1 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6: // map.xaml line 29
                {
                    this.text_2 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
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

