using System;
using System.Collections.Generic;
using CoreGraphics;
using BahrainRed;
using BahrainRed.iOS;
using MapKit;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Maps.iOS;
using Xamarin.Forms.Platform.iOS;
using CoreLocation;

[assembly: ExportRenderer(typeof(CustomMap), typeof(CustomMapRenderer))]
namespace BahrainRed.iOS
{
	public class CustomMapRenderer : MapRenderer
	{
		MKPolylineRenderer polylineRenderer;
		List<CustomPin> customPins;

		protected override void OnElementChanged(ElementChangedEventArgs<View> e)
		{
			base.OnElementChanged(e);

			if (e.OldElement != null)
			{
				var nativeMap = Control as MKMapView;
				nativeMap.GetViewForAnnotation = null;
				//nativeMap.OverlayRenderer = null;
				nativeMap.CalloutAccessoryControlTapped -= OnCalloutAccessoryControlTapped;

			}

			if (e.NewElement != null)
			{
				var formsMap = (CustomMap)e.NewElement;
				var nativeMap = Control as MKMapView;
				customPins = formsMap.CustomPins;
				/*
				nativeMap.OverlayRenderer = GetOverlayRenderer;

				CLLocationCoordinate2D[] coords = new CLLocationCoordinate2D[formsMap.RouteCoordinates.Count];

				int index = 0;
				foreach (var position in formsMap.RouteCoordinates)
				{
					coords[index] = new CLLocationCoordinate2D(position.Latitude, position.Longitude);
					index++;
				}

				var routeOverlay = MKPolyline.FromCoordinates(coords);
				nativeMap.AddOverlay(routeOverlay);
*/
				nativeMap.GetViewForAnnotation = GetViewForAnnotation;
				nativeMap.CalloutAccessoryControlTapped += OnCalloutAccessoryControlTapped;

			}
		}

		MKAnnotationView GetViewForAnnotation(MKMapView mapView, IMKAnnotation annotation)
		{
			MKAnnotationView annotationView = null;

			if (annotation is MKUserLocation)
				return null;

			var anno = annotation as MKPointAnnotation;
			var customPin = GetCustomPin(anno);
			if (customPin == null)
			{
				throw new Exception("Custom pin not found");
			}

			annotationView = mapView.DequeueReusableAnnotation(customPin.Id);
			if (annotationView == null)
			{
				annotationView = new CustomMKAnnotationView(annotation, customPin.Id);
				annotationView.Image = UIImage.FromFile(customPin.PinImage);
				annotationView.CalloutOffset = new CGPoint(0, 0);
				var image = new UIImageView(new CGRect(0, 0, 80, 80));
				image.Image = UIImage.FromFile(customPin.Stop.Image);
				annotationView.LeftCalloutAccessoryView = image;
				annotationView.RightCalloutAccessoryView = UIButton.FromType(UIButtonType.DetailDisclosure);
				((CustomMKAnnotationView)annotationView).Id = customPin.Id;
				((CustomMKAnnotationView)annotationView).Stop = customPin.Stop;
				((CustomMKAnnotationView)annotationView).DisplayInfoCommand = customPin.DisplayInfoCommand;
			}
			annotationView.CanShowCallout = true;

			return annotationView;
		}

		MKOverlayRenderer GetOverlayRenderer(MKMapView mapView, IMKOverlay overlay)
		{
			if (polylineRenderer == null)
			{
				polylineRenderer = new MKPolylineRenderer(overlay as MKPolyline);
				polylineRenderer.FillColor = UIColor.Blue;
				polylineRenderer.StrokeColor = UIColor.Red;
				polylineRenderer.LineWidth = 3;
				polylineRenderer.Alpha = 0.4f;
			}
			return polylineRenderer;
		}

		void OnCalloutAccessoryControlTapped(object sender, MKMapViewAccessoryTappedEventArgs e)
		{
			var customView = e.View as CustomMKAnnotationView;
			if (customView.Stop != null)
			{
				customView.DisplayInfoCommand.Execute(customView.Stop);
			}
		}

		CustomPin GetCustomPin(MKPointAnnotation annotation)
		{
			var position = new Position(annotation.Coordinate.Latitude, annotation.Coordinate.Longitude);
			foreach (var pin in customPins)
			{
				if (pin.Pin.Position == position)
				{
					return pin;
				}
			}
			return null;
		}
	}
}
