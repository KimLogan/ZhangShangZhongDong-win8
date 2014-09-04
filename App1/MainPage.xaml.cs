using Com.AMap.Maps.Api.BaseTypes;
using Com.AMap.Maps.Api.Overlays;
using Com.AMap.Maps.Api;
using Com.AMap.Search.API;
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

// “空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=234238 上有介绍

namespace App1
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public Rect WindowsRect = Window.Current.Bounds;    //获得当前屏幕的边界
        public class block  // 定义的一个储存数据的类
        {
            public string Title { get; set; }
            public string imagePath { get; set; }
            public string Subtitle { get; set; }
        }

        public MainPage()
        {
            this.InitializeComponent();
            Window.Current.SizeChanged += OnSizeChanged;    // 在改变窗口尺寸的委托链上增加该委托

            List<block> storeData = new List<block>()
            {
                //初始化数据
                new block(){ Title = "孤岛今昔", Subtitle = "大学城变迁记", imagePath = "Assets/south.jpg" },
                new block(){ Title = "中大东校", Subtitle = "广州大学城", imagePath = "Assets/east1.jpg"  },
                new block(){ Title = "关于", Subtitle = "团队信息", imagePath = "Assets/team.jpg" },
            };

            //将数据赋值给模板
            MyGridView.ItemsSource = storeData;
            MyListView.ItemsSource = storeData;

            AMapConfig.Key = "abed400b0694feabc185fca01e7091ed";    // 获得高德地图密钥
            AMapSearchConfig.Key = "abed400b0694feabc185fca01e7091ed";
            // (113.298826,23.096374) 南校区
            // (113.391898,23.066806) 东校区
            // (113.289583,23.127914) 北校区
            // (113.589781,22.341294) 珠海校区
        }

        private void OnSizeChanged(object sender, Windows.UI.Core.WindowSizeChangedEventArgs e) // 贴靠处理
        {
            double AppWidth = e.Size.Width;
            double AppHeight = e.Size.Height;
            if (AppWidth <= WindowsRect.Width / 2)
            {
                MyGridView.Visibility = Visibility.Collapsed;
                GridTitle.Visibility = Visibility.Collapsed;
                MyListView.Visibility = Visibility.Visible;
                ListTitle.Visibility = Visibility.Visible;
            }
            else
            {
                MyGridView.Visibility = Visibility.Visible;
                GridTitle.Visibility = Visibility.Visible;
                MyListView.Visibility = Visibility.Collapsed;
                ListTitle.Visibility = Visibility.Collapsed;
            }
        }
        private void MapType_SelectionChanged(object sender, SelectionChangedEventArgs e)   // 选择进入的校区
        {
            var rootFrame = new Frame();
            if (MyGridView.SelectedIndex == 0 || MyListView.SelectedIndex == 0)
            {
                rootFrame.Navigate(typeof(BlankPage10));

                // Place the frame in the current Window and ensure that it is active
                Window.Current.Content = rootFrame;
                Window.Current.Activate();
            }
            else if (MyGridView.SelectedIndex == 1 || MyListView.SelectedIndex == 1)
            {
                rootFrame.Navigate(typeof(EastCampus));
                Window.Current.Content = rootFrame;
                Window.Current.Activate();
            }
            else if (MyGridView.SelectedIndex == 2 || MyListView.SelectedIndex == 2)
            {
                rootFrame.Navigate(typeof(About));
                Window.Current.Content = rootFrame;
                Window.Current.Activate();
            }
        }
    }
}
