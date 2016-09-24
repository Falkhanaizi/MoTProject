using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

using Xamarin.Forms;

namespace BahrainRed
{
	public partial class StopInfoPage : ContentPage
	{
		public StopInfoPage()
		{
			InitializeComponent();

			var stop = TripsManager.GetSavedStops().First();

			//var time = Convert.ToDateTime(stop.SatGoTimetable.First(p => Convert.ToDateTime(p).Subtract(DateTime.Now).TotalSeconds > 0)).Subtract(DateTime.Now).ToString();

			var time = Convert.ToDateTime(stop.SatGoTimetable.First(p => Convert.ToDateTime(p).Subtract(DateTime.Now).TotalSeconds > 0)).Subtract(DateTime.Now);

			Device.StartTimer(TimeSpan.FromSeconds(1), () =>
				{
					time = time.Subtract(TimeSpan.FromSeconds(1));
					RemainingTimeLabel.Text = string.Format("Next Bus in {0}min {1}sec", time.Minutes, time.Seconds);
					if ((int)time.TotalSeconds == 0)
					{
						time = stop.FriGoingTimeSpan;
					}
					return true;
				});

		}
	}
}
