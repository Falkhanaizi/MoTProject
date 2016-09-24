using System;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace BahrainRed
{
	public class CustomPin
	{
		public Pin Pin { get; private set; }
		public string Id { get; private set; }
		public string PinImage { get; private set; }
		public Stop Stop { get; private set; }
		public ICommand DisplayInfoCommand { private set; get; }

		public CustomPin(Pin pin, string id, string pinImage, Stop stop, Action<Stop> displayInfoCommand)
		{
			Pin = pin;
			Id = id;
			PinImage = pinImage;
			Stop = stop;
			DisplayInfoCommand = new Command<Stop>(displayInfoCommand);
		}
	}
}

