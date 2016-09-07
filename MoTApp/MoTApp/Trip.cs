using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Media;

namespace MoTApp
{
    public class Trip
    {
        public Stop startLocation { get; set; }
        public Stop endLocation { get; set; }
        public string fromTime { get; set; }
        public string toTime { get; set; }
        public string duration { get { TimeSpan span = Convert.ToDateTime(toTime).Subtract(Convert.ToDateTime(fromTime)); return string.Format("{0}h {1}min", span.Hours, span.Minutes); } }
        public int numberOfStops { get { return stops.Count; } }
        public List<Stop> stops { get; set; }
        public Route route { get; set; }
        public double totalCost
        {
            get
            {
                double total = 0;
                foreach (var stop in stops)
                {
                    total += stop.zone.price;
                }
                return total / 1000;
            }
        }
    }

    public class Stop
    {
        public string city { get; set; }
        public string name { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public Zone zone { get; set; }
        public List<string> SatGoTimetable { get; set; }
        public List<string> SatReturnTimetable { get; set; }
        public List<string> SunToThuGoTimetable { get; set; }
        public List<string> SunToThuReturnTimetable { get; set; }
    }

    public class Route
    {
        public string id { get; set; }
        public string name { get; set; }
        public SolidColorBrush color { get; set; }
        public List<Stop> stops { get; set; }
    }

    public class Zone
    {
        public string name { get; set; }
        public double price { get; set; }
    }

    public class TripsManager
    {
        public static List<Stop> GetSavedStops()
        {
            List<Stop> stops = new List<Stop>();

            List<string> SatGoTimes = new List<string> { "10:00", "11:00","12:00","13:00","14:00", "11:00", "12:00", "13:00", "14:00" , "11:00", "12:00", "13:00", "14:00" , "11:00", "12:00", "13:00", "14:00" , "11:00", "12:00", "13:00", "14:00" , "11:00", "12:00", "13:00", "14:00" };
            List<string> SatReturnTimes = new List<string> { "11:00", "11:40", "12:00", "13:08", "14:00" };
            List<string> SunToThuGoTimes = new List<string> { "10:25", "11:00", "12:33", "13:00", "14:00" };
            List<string> SunToThuReturnTimes = new List<string> { "10:50", "11:11", "12:00", "13:10", "14:00" };

            stops.Add(new Stop { name = "main terminal 1", SatGoTimetable = SatGoTimes, SatReturnTimetable = SatReturnTimes, SunToThuGoTimetable = SunToThuGoTimes, SunToThuReturnTimetable = SunToThuReturnTimes, city = "manama"});
            stops.Add(new Stop { name = "main terminal 2", SatGoTimetable = SatGoTimes, SatReturnTimetable = SatReturnTimes, SunToThuGoTimetable = SunToThuGoTimes, SunToThuReturnTimetable = SunToThuReturnTimes, city = "manama" });
            stops.Add(new Stop { name = "main terminal 3", SatGoTimetable = SatGoTimes, SatReturnTimetable = SatReturnTimes, SunToThuGoTimetable = SunToThuGoTimes, SunToThuReturnTimetable = SunToThuReturnTimes, city = "manama" });
            stops.Add(new Stop { name = "main terminal 4", SatGoTimetable = SatGoTimes, SatReturnTimetable = SatReturnTimes, SunToThuGoTimetable = SunToThuGoTimes, SunToThuReturnTimetable = SunToThuReturnTimes, city = "manama" });
            stops.Add(new Stop { name = "main terminal 5", SatGoTimetable = SatGoTimes, SatReturnTimetable = SatReturnTimes, SunToThuGoTimetable = SunToThuGoTimes, SunToThuReturnTimetable = SunToThuReturnTimes, city = "manama" });
            stops.Add(new Stop { name = "main terminal 6", SatGoTimetable = SatGoTimes, SatReturnTimetable = SatReturnTimes, SunToThuGoTimetable = SunToThuGoTimes, SunToThuReturnTimetable = SunToThuReturnTimes, city = "manama" });


            return stops;
        }

        public static List<Trip> GetSavedTrips()
        {
            var trips = new List<Trip>();

            Stop stop1 = new Stop { name = "Main Terminal", city = "Manama", latitude = 2.0394, longitude = 3.3742, zone = new Zone { name = "zone 1", price = 100} };
            Stop stop2 = new Stop { name = "Secind Terminal", city = "A'ali", latitude = 1.9373, longitude = 4.1722, zone = new Zone { name = "zone 2", price = 200 } };

            List<Stop> tripStops = new List<Stop>();

            tripStops.Add(stop1);
            tripStops.Add(stop2);
            tripStops.Add(new Stop { name = "Main Terminal", city = "Manama", latitude = 2.0394, longitude = 3.3742, zone = new Zone { name = "zone 1", price = 100 } });
            tripStops.Add(new Stop { name = "Main Terminal", city = "Manama", latitude = 2.0394, longitude = 3.3742, zone = new Zone { name = "zone 1", price = 100 } });
            tripStops.Add(new Stop { name = "Main Terminal", city = "Manama", latitude = 2.0394, longitude = 3.3742, zone = new Zone { name = "zone 1", price = 100 } });
            tripStops.Add(new Stop { name = "Main Terminal", city = "Manama", latitude = 2.0394, longitude = 3.3742, zone = new Zone { name = "zone 1", price = 100 } });
            tripStops.Add(new Stop { name = "Main Terminal", city = "Manama", latitude = 2.0394, longitude = 3.3742, zone = new Zone { name = "zone 1", price = 100 } });
            tripStops.Add(new Stop { name = "Main Terminal", city = "Manama", latitude = 2.0394, longitude = 3.3742, zone = new Zone { name = "zone 1", price = 100 } });
            tripStops.Add(new Stop { name = "Main Terminal", city = "Manama", latitude = 2.0394, longitude = 3.3742, zone = new Zone { name = "zone 1", price = 100 } });


            trips.Add(new Trip { startLocation = stop1, endLocation = stop2, fromTime = "10:00", toTime = "11:25", stops = tripStops, route = new Route { name = "B1", stops = new List<Stop> { stop1 } } });
            trips.Add(new Trip { startLocation = stop1, endLocation = stop2, fromTime = "10:00", toTime = "11:25", stops = tripStops, route = new Route { name = "B1", stops = new List<Stop> { stop1 } } });
            trips.Add(new Trip { startLocation = stop1, endLocation = stop2, fromTime = "10:00", toTime = "11:25", stops = tripStops, route = new Route { name = "B1", stops = new List<Stop> { stop1 } } });
            trips.Add(new Trip { startLocation = stop1, endLocation = stop2, fromTime = "10:00", toTime = "11:25", stops = tripStops, route = new Route { name = "B1", stops = new List<Stop> { stop1 } } });
            trips.Add(new Trip { startLocation = stop1, endLocation = stop2, fromTime = "10:00", toTime = "11:25", stops = tripStops, route = new Route { name = "B1", stops = new List<Stop> { stop1 } } });
            trips.Add(new Trip { startLocation = stop1, endLocation = stop2, fromTime = "10:00", toTime = "11:25", stops = tripStops, route = new Route { name = "B1", stops = new List<Stop> { stop1 } } });
            trips.Add(new Trip { startLocation = stop1, endLocation = stop2, fromTime = "10:00", toTime = "11:25", stops = tripStops, route = new Route { name = "B1", stops = new List<Stop> { stop1 } } });
            trips.Add(new Trip { startLocation = stop1, endLocation = stop2, fromTime = "10:00", toTime = "11:25", stops = tripStops, route = new Route { name = "B1", stops = new List<Stop> { stop1 } } });
            trips.Add(new Trip { startLocation = stop1, endLocation = stop2, fromTime = "10:00", toTime = "11:25", stops = tripStops, route = new Route { name = "B1", stops = new List<Stop> { stop1 } } });
            trips.Add(new Trip { startLocation = stop1, endLocation = stop2, fromTime = "10:00", toTime = "11:25", stops = tripStops, route = new Route { name = "B1", stops = new List<Stop> { stop1 } } });
            trips.Add(new Trip { startLocation = stop1, endLocation = stop2, fromTime = "10:00", toTime = "11:25", stops = tripStops, route = new Route { name = "B1", stops = new List<Stop> { stop1 } } });
            trips.Add(new Trip { startLocation = stop1, endLocation = stop2, fromTime = "10:00", toTime = "11:25", stops = tripStops, route = new Route { name = "B1", stops = new List<Stop> { stop1 } } });

            return trips;
        }

        public static List<Route> GetSavedRoutes()
        {
            List<Route> routes = new List<Route>();

            routes.Add(new Route { id = "A1", color = GetSolidColorBrush("FF4A18D1"), stops = GetSavedStops()});
            routes.Add(new Route { id = "B1", color = GetSolidColorBrush("FE4A18D1"), stops = GetSavedStops()});
            routes.Add(new Route { id = "C2", color = GetSolidColorBrush("FF4A08D1"), stops = GetSavedStops()});
            routes.Add(new Route { id = "X2B", color = GetSolidColorBrush("FF4A18A1"), stops = GetSavedStops()});
            routes.Add(new Route { id = "X2B", color = GetSolidColorBrush("FF4A18A1"), stops = GetSavedStops() });
            routes.Add(new Route { id = "X2B", color = GetSolidColorBrush("FF4A18A1"), stops = GetSavedStops() });
            routes.Add(new Route { id = "X2B", color = GetSolidColorBrush("FF4A18A1"), stops = GetSavedStops() });
            routes.Add(new Route { id = "X2B", color = GetSolidColorBrush("FF4A18A1"), stops = GetSavedStops() });
            routes.Add(new Route { id = "X2B", color = GetSolidColorBrush("FF4A18A1"), stops = GetSavedStops() });
            routes.Add(new Route { id = "X2B", color = GetSolidColorBrush("FF4A18A1"), stops = GetSavedStops() });
            routes.Add(new Route { id = "X2B", color = GetSolidColorBrush("FF4A18A1"), stops = GetSavedStops() });
            routes.Add(new Route { id = "X2B", color = GetSolidColorBrush("FF4A18A1"), stops = GetSavedStops() });
            routes.Add(new Route { id = "X2B", color = GetSolidColorBrush("FF4A18A1"), stops = GetSavedStops() });
            routes.Add(new Route { id = "X2B", color = GetSolidColorBrush("FF4A18A1"), stops = GetSavedStops() });
            routes.Add(new Route { id = "X2B", color = GetSolidColorBrush("FF4A18A1"), stops = GetSavedStops() });
            routes.Add(new Route { id = "X2B", color = GetSolidColorBrush("FF4A18A1"), stops = GetSavedStops() });

            return routes;
        }

        // convert a hex value to a color
        public static SolidColorBrush GetSolidColorBrush(string hex)
        {
            hex = hex.Replace("#", string.Empty);
            byte a = (byte)(Convert.ToUInt32(hex.Substring(0, 2), 16));
            byte r = (byte)(Convert.ToUInt32(hex.Substring(2, 2), 16));
            byte g = (byte)(Convert.ToUInt32(hex.Substring(4, 2), 16));
            byte b = (byte)(Convert.ToUInt32(hex.Substring(6, 2), 16));
            SolidColorBrush myBrush = new SolidColorBrush(Color.FromArgb(a, r, g, b));
            return myBrush;
        }
    }
}
