using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// https://go.microsoft.com/fwlink/?LinkId=234238 上介绍了“空白页”项模板

namespace LostAndFound
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class newItem : Page
    {
        public newItem()
        {
            this.InitializeComponent();
        }

        //确认发布新启事
        private void newItemSure(object sender, RoutedEventArgs e)
        {

        }

        private void backToMain(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(denglu));
        }
    }
}
