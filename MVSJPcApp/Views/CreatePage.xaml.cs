using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Bluetooth.Advertisement;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Microsoft.Graphics.Canvas.Effects;
using Microsoft.Toolkit.Uwp.UI.Animations;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace MVSJPcApp.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CreatePage : Page
    {
        public CreatePage()
        {
            this.InitializeComponent();
            
        }
        
        

       

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            
            if (CreatePopUp.IsOpen)
            {
                CreatePopUp.IsOpen = false;
                

            }
        }

        private void CreateButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (!CreatePopUp.IsOpen)
            {
                CreatePopUp.IsOpen = true;
            }
        }

        private void CreatePopUp_Opened(object sender, object e)
        {
            BlurGrid.Blur(5, 0, 0).Start();
        }

        private void CreatePopUp_Closed(object sender, object e)
        {
            BlurGrid.Blur(0,0,0).Start();
        }
    }
}
