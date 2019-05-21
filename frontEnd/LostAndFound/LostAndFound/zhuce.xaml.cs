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
using Windows.Web.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

// https://go.microsoft.com/fwlink/?LinkId=234238 上介绍了“空白页”项模板

namespace LostAndFound
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class zhuce : Page
    {
        public zhuce()
        {
            this.InitializeComponent();
        }

        private async void Register_Button_Click(object sender, RoutedEventArgs e)
        {
            //获取两个输入框的值
            string username = username_new.Text;
            string password = password_new.Text;
            string phoneNo = phoneNo_new.Text;
            if (username == "" || password == "")
            {
                ShowMessageDialog("用户名和密码不允许为空！");
            }
            //要访问的接口路径
            var uri = new Uri("https://lostandfoundapp.chinacloudsites.cn/user/register?username="
                + username + "&password=" + password + "&phoneNo="+phoneNo);
            var httpClient = new HttpClient();
            // Always catch network exceptions for async methods
            try
            {
                string result = await httpClient.GetStringAsync(uri);
                //object product = JsonConvert.DeserializeObject(result);
                JObject resultObj = JObject.Parse(result);
                //如果status不为1，说明注册失败，将报错信息以弹框方式显示。
                if (int.Parse(resultObj["status"].ToString()) != 1)
                {
                    ShowMessageDialog(resultObj["msg"].ToString());
                }
                else
                {
                    //注册成功，跳转页面
                    this.Frame.Navigate(typeof(MainPage));
                    //resultObj["userId"]是可以取到id的，需要保存下来，跳转页面的时候传参传过去
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
    }
}
