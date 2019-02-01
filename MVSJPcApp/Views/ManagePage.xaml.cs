using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.UserDataTasks.DataProvider;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Microsoft.Toolkit.Uwp.UI.Animations;
using MVSJPcApp.ViewModels;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace MVSJPcApp.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ManagePage : Page
    {
        public ManagePage()
        {
            this.InitializeComponent();
         
        }

        

      
        private void ArrangeBox_OnUnchecked(object sender, RoutedEventArgs e)
        {

        }

        private void ArrangeBox_OnChecked(object sender, RoutedEventArgs e)
        {
           
        }

       
       
        

        private void CreatePopUp_OnClosed(object sender, object e)
        {
            if (CreatePopUp.IsOpen == false)
            {
                BlurGrid.Blur(0, 0, 0).Start();
            }
            
        }

       
        private void DeleteBase_OnClick(object sender, RoutedEventArgs e)
        {
            
        }

        private void ManagePage2Base_OnClick(object sender, RoutedEventArgs e)
        {
            ListFrame.Navigate(typeof(ManagePage2));
        }

        private void CreatePopUpOpen_OnClick(object sender, RoutedEventArgs e)
        {
            if (!CreatePopUp.IsOpen)
            {
                CreatePopUp.IsOpen = true;
                BlurGrid.Blur(10, 1, 0).Start();
            }
        }

        private void ClosePopUp_OnClick(object sender, RoutedEventArgs e)
        {
            CreatePopUp.IsOpen = false;
        }

       
    }
}
