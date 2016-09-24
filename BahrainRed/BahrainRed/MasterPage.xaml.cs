using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BahrainRed
{
	public partial class MasterPage : ContentPage
	{
		public ListView ListView { get { return listView; } }

		public MasterPage()
		{
			InitializeComponent();
			var masterPageItems = new List<MasterPageItem>() 
			{
				new MasterPageItem("Home", "icon_Home2.png", typeof(HomePage)),
				new MasterPageItem("Route Details", "icon_map.png", typeof(RouteDetailsPage)),
				new MasterPageItem("Trip Planner", "icon_calendar.png", typeof(TripPlannerPage)),
				new MasterPageItem("Saved Trips", "icon_star.png", typeof(SavedTripsPage)),
				new MasterPageItem("Feedback", "icon_feedback.png", typeof(FeedbackPage))
			};

			listView.ItemsSource = masterPageItems;
		}
	}

	public class MasterPageItem
	{
		public string Title { get; private set; }

		public string IconSource { get; private set; }

		public Type TargetType { get; private set; }

		public MasterPageItem(string title, string iconSource, Type page) 
		{
			Title = title;
			IconSource = iconSource;
			TargetType = page;
		}
	}
}
