using LostAndFound.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

    public sealed partial class itemInfo : Page
    {
        public ItemViewModel itemViewModel { get; set; }
        public Item item = new Item(1, 1, "钱包", "和平大路", "2","李四si", "hhballalala", "hahha", "2019-05-23");
        private int itemId = 1;
        public itemInfo()
        {
            this.InitializeComponent();
            this.itemViewModel = new ItemViewModel();
            //this.item.Place = "哗哗哗";
        }

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            int itemId = (int)e.Parameter;
            Debug.WriteLine("在启事详情页面获取到的itemId为"+itemId.ToString());
            this.item = await itemViewModel.getItemAsync(itemId);
            this.Bindings.Update();
            base.OnNavigatedTo(e);
        }
        private void backToMain(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(denglu));
        }

        //向启事添加评论
        private void comment(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(sendMsg),this.itemId);
        }

        //添加收藏
        private void addToStar(object sender, RoutedEventArgs e)
        {

        }
    }
}
