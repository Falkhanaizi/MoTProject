using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BahrainRed
{
	public partial class HomePage : CarouselPage
	{

		public HomePage()
		{
			NavigationPage.SetHasNavigationBar(this, false);
			InitializeComponent();

			var updatePageItems = new List<UpdatePageItem>()
			{
				new UpdatePageItem("Home \n \n \n blah", "BahrainBus1.jpg"),
				new UpdatePageItem("Home", "BahrainBus2.jpg"),
				new UpdatePageItem("Home", "BahrainBus3.jpg")
			};

			ItemsSource = updatePageItems;
		}
	}

	public class UpdatePageItem
	{
		public string UpdateText { get; private set; }

		public string UpdateImage { get; private set; }

		public UpdatePageItem(string text, string image)
		{
			UpdateText = text;
			UpdateImage = image;
		}
	}
}
