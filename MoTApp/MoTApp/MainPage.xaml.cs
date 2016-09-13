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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MoTApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            MyFrame.Navigate(typeof(HomePage));

            List<HomePageViewModel> models = new List<HomePageViewModel>
            {
                new HomePageViewModel(typeof(HomePage)) {PageImage = "Assets/icon_Home2.png" },
                new HomePageViewModel(typeof(Trip_PlannerPage)) {PageImage = "Assets/icon_calendar.png" },
                new HomePageViewModel(typeof(FeedbackPage)) {PageImage = "Assets/icon_feedback.png" },
                new HomePageViewModel(typeof(Route_DetailsPage)) {PageImage = "Assets/icon_map.png" },
                new HomePageViewModel(typeof(Saved_TripsPage)) {PageImage = "Assets/icon_star.png" }
            };
            PagesList.ItemsSource = models;
        }

        private void PagesList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var page = (HomePageViewModel)PagesList.SelectedItem;
            MyFrame.Navigate(page.PageType);
            if (!page.PageName.ToLower().Contains("home"))
            {
                MenuBtn.Margin = new Thickness(50, 0, 0, 0);
            }
            else
            {
                MenuBtn.Margin = new Thickness(10, 0, 0, 0);
            }
        }

        private void MenuBtn_Tapped(object sender, TappedRoutedEventArgs e)
        {
            PagesSplitView.IsPaneOpen = true;
        }
    }
}
