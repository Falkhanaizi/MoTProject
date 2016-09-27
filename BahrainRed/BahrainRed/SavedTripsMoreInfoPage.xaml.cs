using System;
using System.Collections.Generic;
using System.Linq;

using Xamarin.Forms;

namespace BahrainRed
{
	public partial class SavedTripsMoreInfoPage : ContentPage
	{
		public SavedTripsMoreInfoPage()
		{
			InitializeComponent();
			this.BindingContext = TripsManager.GetSavedTrips().First();
			tripDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
			StopsList.ItemsSource = TripsManager.GetSavedTrips().First().stops.Select(s => s.city + ", " + s.name + " 10:00").ToList<string>();
		}

		void ReminderBtn_Clicked(object sender, System.EventArgs e)
		{
		}

		void EditBtn_Clicked(object sender, System.EventArgs e)
		{
		}

		void QuitBtn_Clicked(object sender, System.EventArgs e)
		{
			this.Navigation.PopToRootAsync();
		}
	}
}
