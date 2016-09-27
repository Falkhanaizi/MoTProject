using System;
using System.Collections.Generic;
using System.Linq;

using Xamarin.Forms;

namespace BahrainRed
{
	public partial class RoutesListPage : ContentPage
	{
		public RoutesListPage()
		{
			InitializeComponent();

			var routes = TripsManager.GetSavedRoutes();

			listView.ItemsSource = routes;
		}
	}
}
