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
            this.Frame.Navigate(typeof(map));
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
    }

}
