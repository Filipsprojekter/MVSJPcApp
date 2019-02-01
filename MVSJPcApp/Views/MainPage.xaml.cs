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
using MVSJPcApp.Views;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MVSJPcApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void RadioButtonPaneItem_Click(object sender, RoutedEventArgs e)
        {
            var radioButton = sender as RadioButton;
            if (radioButton != null)
                switch (radioButton.Tag.ToString())
                {
                    case "Search":
                        MainFrame.Navigate(typeof(SearchPage));
                        break;
                    case "Create":
                        MainFrame.Navigate(typeof(CreatePage));
                        break;
                    case "Manage":
                        MainFrame.Navigate(typeof(ManagePage));
                        break;
                    case "Add Models":
                        MainFrame.Navigate(typeof(AddModelsPage));
                        break;
                }
        }

        private void HamburgerButton_OnClick(object sender, RoutedEventArgs e)
        {
            this.MySplitView.IsPaneOpen = this.MySplitView.IsPaneOpen ? false : true;
        }

       
    }
}
