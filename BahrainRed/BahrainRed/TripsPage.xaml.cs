using System;
using System.Collections.Generic;
using System.Linq;

using Xamarin.Forms;

namespace BahrainRed
{
	public partial class TripsPage : ContentPage
	{
		public TripsPage()
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
				this.Navigation.PushAsync(new TripsMoreInfoPage());
			}
		}
	}
}
