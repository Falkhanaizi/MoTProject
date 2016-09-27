using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using Bahrain.iOS;

[assembly: ExportRenderer(typeof(TimePicker), typeof(TimePicker24HRenderer))]
namespace Bahrain.iOS
{
	public class TimePicker24HRenderer : TimePickerRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<TimePicker> e)
		{
			base.OnElementChanged(e);
			var timePicker = (UIDatePicker)Control.InputView;
			timePicker.Locale = new NSLocale("no_nb");
		}
	}
}

