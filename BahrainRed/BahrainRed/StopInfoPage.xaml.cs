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

			string nextTime;

			if (DateTime.Now.Hour == 23)
			{
				nextTime = "00:00";
			}
			else
			{
				nextTime = stop.SatGoTimetable.First(p => Convert.ToDateTime(p).Subtract(DateTime.Now).TotalSeconds > 0);

			}

			var time = Convert.ToDateTime(nextTime).Subtract(DateTime.Now);

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
