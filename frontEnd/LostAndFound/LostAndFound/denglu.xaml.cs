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
using Windows.UI.Xaml.Controls.Maps;
using Windows.Devices.Geolocation;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Diagnostics;



// https://go.microsoft.com/fwlink/?LinkId=234238 上介绍了“空白页”项模板

namespace LostAndFound
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class denglu : Page
    {

        public denglu()
        {
            this.InitializeComponent();
            getRecommendedItemsAsync();
        }
        

        public async static Task<Geoposition> GetPosition()
        {
            //请求对位置的访问权
            var accessStatus = await Geolocator.RequestAccessAsync();
            //此时，窗口会弹出提示是否允许应用访问位置，如果用户不允许则抛出异常
            if (accessStatus != GeolocationAccessStatus.Allowed) throw new Exception();
            //实例化定位类，并设置经纬度精确度（单位：米），一般为零，为保护用户隐私，建议减少精确度
            var geolocator = new Geolocator { DesiredAccuracyInMeters = 0 };
            //异步获取设备位置，并将位置保存到变量中（Geoposition类型）
            var position = await geolocator.GetGeopositionAsync();
            //返回位置
            return position;
        }
        
        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("here in the load fun");
            await testFunAsync();
            await getRecommendedItemsAsync();
            //异步获取位置，保存到变量中
            var position = await denglu.GetPosition();
            //维度
            double lat = position.Coordinate.Point.Position.Latitude;
            //经度
            double lon = position.Coordinate.Point.Position.Longitude;
            location_text.Text = lat.ToString();
        }

        private void goback_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.GoBack();
        }

        private void fanwei_combox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private async void fabu_button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(newItem));
        }


        private async void Image_Tapped_1(object sender, TappedRoutedEventArgs e)
        {
         
            var position = await denglu.GetPosition();
            //维度
            double lat = position.Coordinate.Point.Position.Latitude;
          
            //经度
            double lon = position.Coordinate.Point.Position.Longitude;
            location_text.Text = "维度："+lat.ToString("f3")+" ,"+"经度："+lon.ToString("f3");
        }

        private void userCenter_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(UserPage));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
        private void clickItem(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(itemInfo));
        }

        private async Task getRecommendedItemsAsync() {
            try
            {
                //获取全局的client对象，进行接口访问
                HttpClient client = (Application.Current as App).client;
                //接口的路径，与接口文档保持一致
                var uri = new Uri("https://lostandfoundapp.chinacloudsites.cn/item/getNearItems" +
                    "?longitude=116.45543&latitude=39.87333&type=1&category=钱包&range=1000&num=3");
                HttpResponseMessage response = await client.GetAsync(uri);
                Debug.WriteLine(response);
                JObject resultObj = JObject.Parse(response.Content.ReadAsStringAsync().Result);
                //如果status不为1，说明登录失败，将报错信息以弹框方式显示。
                if (int.Parse(resultObj["status"].ToString()) != 1)
                {
                    ShowMessageDialog(resultObj["msg"].ToString());
                }
                else
                {
                    //根据文档可知，此方法传出结果的“itemInfo”是一个数组，用JAarry解析
                    JArray items = JArray.Parse(resultObj["itemInfo"].ToString());
                    for (int i = 0; i < items.Count; i++) {
                        JObject item = JObject.Parse(items[i].ToString());
                        //测试是否已经拿到了数据，测试可用
                        Debug.WriteLine(item["category"]);
                    }
                }
            }
            catch
            {
                // Details in ex.Message and ex.HResult.   
            }

            async void ShowMessageDialog(string msg)
            {
                var msgDialog = new Windows.UI.Popups.MessageDialog(msg) { Title = "提示" };
                msgDialog.Commands.Add(new Windows.UI.Popups.UICommand("确定"));
                await msgDialog.ShowAsync();
            }
        }
        public async Task testFunAsync()
        {
            Debug.WriteLine("in the function testFun in denglu");
            try
            {
                HttpClient client = (Application.Current as App).client;
                var uri = new Uri("https://lostandfoundapp.chinacloudsites.cn/user/getUser");
                HttpResponseMessage response = await client.GetAsync(uri);
                JObject resultObj = JObject.Parse(response.Content.ReadAsStringAsync().Result);
                Debug.WriteLine(resultObj);
                Debug.WriteLine(resultObj["username"]);
            }
            catch
            {
                // Details in ex.Message and ex.HResult.   
            }

            async void ShowMessageDialog(string msg)
            {
                var msgDialog = new Windows.UI.Popups.MessageDialog(msg) { Title = "提示" };
                msgDialog.Commands.Add(new Windows.UI.Popups.UICommand("确定"));
                await msgDialog.ShowAsync();
            }
        }
    }

}
