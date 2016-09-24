using System;
using System.Collections.Generic;
using System.Linq;

using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace BahrainRed
{
	public class CustomMap : Map
	{
		public List<Position> RouteCoordinates { get { return CustomPins.Select(p => p.Pin.Position).ToList<Position>(); }}
		public List<CustomPin> CustomPins { get; set; }

		public CustomMap()
		{
			CustomPins = new List<CustomPin>();
		}
	}
}

