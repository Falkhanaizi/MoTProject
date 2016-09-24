using MapKit;
using System.Windows.Input;

namespace BahrainRed.iOS
{
	public class CustomMKAnnotationView : MKAnnotationView
	{
		public string Id { get; set; }

		public Stop Stop { get; set; }

		public ICommand DisplayInfoCommand { get; set; }

		public CustomMKAnnotationView(IMKAnnotation annotation, string id)
			: base(annotation, id)
		{
		}
	}
}
