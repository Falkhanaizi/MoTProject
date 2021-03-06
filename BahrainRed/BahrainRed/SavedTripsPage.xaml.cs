﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BahrainRed
{
	public partial class SavedTripsPage : ContentPage
	{
		public SavedTripsPage()
		{
			InitializeComponent();
			NavigationPage.SetBackButtonTitle(this, "");

			TripsList.ItemsSource = TripsManager.GetSavedTrips();

		}

		void TripsList_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
		{
			var item = e.SelectedItem as Trip;
			if (item != null)
			{
				this.Navigation.PushAsync(new SavedTripsMoreInfoPage());
			}
		}
	}
}
