using System;
using System.Collections.Generic;
using System.Linq;

using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace BahrainRed
{
	public class CustomMap : Map
	{
		public List<Position> RouteCoordinates { get; private set; }

		public List<CustomPin> CustomPins { get; set; }

		public CustomMap()
		{
			RouteCoordinates = new List<Position>();
			CustomPins = new List<CustomPin>();
		}
	}
}

