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
    public sealed partial class EastCampus : Page
    {
        public EastCampus()
        {
            this.InitializeComponent();
        }

        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void c1_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Page1));
        }

        private void c2_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Page2));
        }

        private void c3_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(food));
        }

        private void c4_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(bus1));
        }
    }
}
