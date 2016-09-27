using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BahrainRed
{
	public partial class TripPlannerPage : ContentPage
	{
		public TripPlannerPage()
		{
			InitializeComponent();

			NavigationPage.SetBackButtonTitle(this, "");

			var routes = TripsManager.GetSavedRoutes();
			foreach (var route in routes)
			{
				foreach (var stop in route.stops)
				{
					FromLocation_Picker.Items.Add(stop.ToString());
					ToLocation_Picker.Items.Add(stop.ToString());
				}
			}
		}

		void trip_btn_Clicked(object sender, System.EventArgs e)
		{
			this.Navigation.PushAsync(new TripsPage());
		}
	}
}
