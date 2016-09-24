using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace BahrainRed
{
	public partial class MapPage : ContentPage
	{
		public MapPage()
		{
			InitializeComponent();


			var stopPage = new StopInfoPage();
			stopPage.BindingContext = TripsManager.GetSavedRoutes().First().stops.First();
			stopInfo.Clicked += (_, e) => Navigation.PushAsync(stopPage);

			customMap.CustomPins = new List<CustomPin>();

			var route = TripsManager.GetSavedRoutes().First();

			foreach (var stop in route.stops)
			{
				var pin = new CustomPin(new Pin() { Type = PinType.Place, Position = new Position(stop.latitude, stop.longitude), Label = stop.name}, stop.name, "pin_RED.png", stop,DisplayInfpPage);
				customMap.CustomPins.Add(pin);                        			
				customMap.Pins.Add(pin.Pin);

			}

			customMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(26.216, 50.497277), Distance.FromMeters(20)));
		}

		async void DisplayInfpPage(Stop stop)
		{
			await this.Navigation.PushAsync(new StopInfoPage() { BindingContext = stop});
		}
	}
}
