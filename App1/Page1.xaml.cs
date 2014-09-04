using Com.AMap.Maps.Api;
using Com.AMap.Maps.Api.BaseTypes;
using Com.AMap.Maps.Api.Overlays;
using Com.AMap.Search.API;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Popups;
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
    public sealed partial class Page1 : Page
    {
        AMap map = new AMap();
        AMarker marker = new AMarker();
        public Page1()
        {
            this.InitializeComponent();
            AMapConfig.Key = "abed400b0694feabc185fca01e7091ed";
            AMapSearchConfig.Key = "abed400b0694feabc185fca01e7091ed";
            mapview.Children.Add(map);
            map.MapLoaded += map_MapLoaded;
        }
        void map_MapLoaded(object sender, RoutedEventArgs e)
        {
            ///适用于高德地图的定位接口
            AGeolocator ageol = new AGeolocator();
            ageol.PositionChanged += ageol_PositionChanged;
        }

        void ageol_PositionChanged(AGeolocator sender, APositionChangedEventArgs args)
        {
            this.Dispatcher.RunAsync(CoreDispatcherPriority.High, () =>
            {
                if (!map.Children.Contains(marker))
                {
                    marker.LngLat = args.LngLat;
                    map.Children.Add(marker);
                }
                else
                {
                    marker.LngLat = args.LngLat;
                }
                map.SetZoomAndCenter(15, args.LngLat);
                Debug.WriteLine("定位精度：" + args.Accuracy);//单位米
            });
        }

        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void AppBarButton_Click1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(EastCampus));
        }

        private void SatelliteLayer(object sender, RoutedEventArgs e)
        {
            AMap map = new AMap();
            map.SetZoomAndCenter(20, new ALngLat(113.391898, 23.066806));
            // (113.298826,23.096374) 南校区
            // (113.391898,23.066806) 东校区
            // (113.289583,23.127914) 北校区
            // (113.589781,22.341294) 珠海校区
            mapview.Children.Add(map);
            map.MapType = MapType.Aerial;
        }

        private void RouteLayer(object sender, RoutedEventArgs e)
        {
            AMap map = new AMap();
            map.SetZoomAndCenter(20, new ALngLat(113.391898, 23.066806));
            // (113.298826,23.096374) 南校区
            // (113.391898,23.066806) 东校区
            // (113.289583,23.127914) 北校区
            // (113.589781,22.341294) 珠海校区
            mapview.Children.Add(map);
            map.MapType = MapType.Road;
        }

        private void Locate(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Page1));
        }
    }
}
