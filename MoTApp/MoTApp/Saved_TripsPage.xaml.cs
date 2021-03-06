﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace MoTApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Saved_TripsPage : Page
    {
        private List<Trip> Trips;

        public Saved_TripsPage()
        {
            this.InitializeComponent();
            Trips = TripsManager.GetSavedTrips();
        }

        private void AddBtn_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(Trip_PlannerPage));
        }

        private void TripsList_ItemClick(object sender, ItemClickEventArgs e)
        {
            var trip = (Trip)e.ClickedItem;
            Frame.Navigate(typeof(SavedTripMoreInfo), trip);
        }
    }
}
