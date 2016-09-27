using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BahrainRed
{
	public partial class FeedbackPage : ContentPage
	{
		public FeedbackPage()
		{
			InitializeComponent();
		}

		void btn_Submit_Clicked(object sender, System.EventArgs e)
		{
			this.Navigation.PopToRootAsync();
		}
	}
}
