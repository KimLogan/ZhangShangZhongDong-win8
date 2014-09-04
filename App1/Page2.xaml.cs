using Com.AMap.Maps.Api;
using Com.AMap.Maps.Api.BaseTypes;
using Com.AMap.Maps.Api.Overlays;
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
    public sealed partial class Page2 : Page
    {
        public Page2()
        {
            this.InitializeComponent();          
        }

        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void AppBarButton_Click1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(EastCampus));
        }

        private void Locate1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(BlankPage1));
        }




        private void Locate6(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(BlankPage6));
        }

        private void Locate7(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(BlankPage7));
        }

        private void Locate8(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(BlankPage8));
        }

        private void Locate9(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(BlankPage9));
        }



        private void Locate12(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(BlankPage12));
        }

        private void Locate13(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(BlankPage13));
        }

        private void Locate14(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(BlankPage14));
        }

        private void Locate15(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(BlankPage15));
        }

        private void Locate16(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(BlankPage16));
        }

        private void Locate17(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(BlankPage17));
        }


    }
}
