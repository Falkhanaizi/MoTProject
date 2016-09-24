using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BahrainRed
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
        public string totalCost
        {
            get
            {
                double total = 0;
                foreach (var stop in stops)
                {
                    total += stop.zone.price;
                }
                return total / 1000 + " BD";
            }
        }
    }

    public class Stop
    {
        public string city { get; set; }
        public string name { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
		public string Image { get; set; }
        public Zone zone { get; set; }
		public TimeSpan FriGoingTimeSpan { get; set; }
		public TimeSpan FriReturningTimeSpan { get; set; }
		public TimeSpan SatToThuGoingTimeSpan { get; set; }
		public TimeSpan SatToThuReturningTimeSpan { get; set; }
        public List<string> SatGoTimetable { get; set; }
        public List<string> SatReturnTimetable { get; set; }
        public List<string> SunToThuGoTimetable { get; set; }
        public List<string> SunToThuReturnTimetable { get; set; }
        public override string ToString()
        {
            return String.Format("{0}, {1}",city,name);
        }
    }

    public class Route
    {
        public string id { get; set; }
        public string name { get; set; }
        private string mapImageSourec;

        public string mapImage
        {
            get { return string.Format(@"Assets/{0}",mapImageSourec); }
            set { mapImageSourec = value; }
        }

        public Color color { get; set; }
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

            List<string> SatGoTimes = new List<string> { "00:00", "01:00","02:00","03:00","04:00", "05:00", "06:00", "07:00", "08:00" , "09:00", "10:00", "11:00", "12:00" , "13:00", "14:00", "15:00", "16:00" , "17:00", "18:00", "19:00", "20:00" , "21:00", "22:00", "23:00" };
            List<string> SatReturnTimes = new List<string> { "00:00", "01:00", "02:00", "03:00", "04:00", "05:00", "06:00", "07:00", "08:00", "09:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00" };
            List<string> SunToThuGoTimes = new List<string> { "00:00", "01:00", "02:00", "03:00", "04:00", "05:00", "06:00", "07:00", "08:00", "09:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00" };
            List<string> SunToThuReturnTimes = new List<string> { "00:00", "01:00", "02:00", "03:00", "04:00", "05:00", "06:00", "07:00", "08:00", "09:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00" };

			TimeSpan timeSpan = TimeSpan.FromHours(1);

			stops.Add(new Stop { name = "main terminal 1", SatGoTimetable = SatGoTimes, SatReturnTimetable = SatReturnTimes, SunToThuGoTimetable = SunToThuGoTimes, SunToThuReturnTimetable = SunToThuReturnTimes, city = "manama", FriGoingTimeSpan = timeSpan, FriReturningTimeSpan = timeSpan, SatToThuGoingTimeSpan = timeSpan, SatToThuReturningTimeSpan = timeSpan, Image = "BahrainBus4.jpg", zone = new Zone {name = "zone 1", price=300}, latitude = 26.215085, longitude = 50.497277});
            stops.Add(new Stop { name = "main terminal 2", SatGoTimetable = SatGoTimes, SatReturnTimetable = SatReturnTimes, SunToThuGoTimetable = SunToThuGoTimes, SunToThuReturnTimetable = SunToThuReturnTimes, city = "saar" , FriGoingTimeSpan = timeSpan, FriReturningTimeSpan = timeSpan, SatToThuGoingTimeSpan = timeSpan, SatToThuReturningTimeSpan = timeSpan, Image = "BahrainBus4.jpg", zone = new Zone { name = "zone 1", price = 300 }, latitude = 26.215095, longitude = 50.497277});
            stops.Add(new Stop { name = "main terminal 3", SatGoTimetable = SatGoTimes, SatReturnTimetable = SatReturnTimes, SunToThuGoTimetable = SunToThuGoTimes, SunToThuReturnTimetable = SunToThuReturnTimes, city = "jidhafs" ,FriGoingTimeSpan = timeSpan, FriReturningTimeSpan = timeSpan, SatToThuGoingTimeSpan = timeSpan, SatToThuReturningTimeSpan = timeSpan, Image = "BahrainBus4.jpg", zone = new Zone { name = "zone 1", price = 300 }, latitude = 26.215185, longitude = 50.497277 });
            stops.Add(new Stop { name = "main terminal 4", SatGoTimetable = SatGoTimes, SatReturnTimetable = SatReturnTimes, SunToThuGoTimetable = SunToThuGoTimes, SunToThuReturnTimetable = SunToThuReturnTimes, city = "Hamad Town" , FriGoingTimeSpan = timeSpan, FriReturningTimeSpan = timeSpan, SatToThuGoingTimeSpan = timeSpan, SatToThuReturningTimeSpan = timeSpan, Image = "BahrainBus4.jpg", zone = new Zone { name = "zone 1", price = 300 }, latitude = 26.215285, longitude = 50.497277});
            stops.Add(new Stop { name = "main terminal 5", SatGoTimetable = SatGoTimes, SatReturnTimetable = SatReturnTimes, SunToThuGoTimetable = SunToThuGoTimes, SunToThuReturnTimetable = SunToThuReturnTimes, city = "Airport" , FriGoingTimeSpan = timeSpan, FriReturningTimeSpan = timeSpan, SatToThuGoingTimeSpan = timeSpan, SatToThuReturningTimeSpan = timeSpan, Image = "BahrainBus4.jpg", zone = new Zone { name = "zone 1", price = 300 }, latitude = 26.215085, longitude = 50.497297});
            stops.Add(new Stop { name = "main terminal 6", SatGoTimetable = SatGoTimes, SatReturnTimetable = SatReturnTimes, SunToThuGoTimetable = SunToThuGoTimes, SunToThuReturnTimetable = SunToThuReturnTimes, city = "Isa Town" , FriGoingTimeSpan = timeSpan, FriReturningTimeSpan = timeSpan, SatToThuGoingTimeSpan = timeSpan, SatToThuReturningTimeSpan = timeSpan, Image = "BahrainBus4.jpg", zone = new Zone { name = "zone 1", price = 300 }, latitude = 26.215085, longitude = 50.497377});


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

            routes.Add(new Route { id = "A1", color = Color.FromHex("FF4A18D1"), stops = GetSavedStops(), mapImage = "33-NL.jpg"});
            routes.Add(new Route { id = "B1", color = Color.FromHex("FE4A18D1"), stops = GetSavedStops(), mapImage = "a1-NL.jpg"});
            routes.Add(new Route { id = "C2", color = Color.FromHex("FF4A08D1"), stops = GetSavedStops(), mapImage = "A2-NL.jpg"});
            routes.Add(new Route { id = "X2B", color = Color.FromHex("FF4A18A1"), stops = GetSavedStops(), mapImage = "A2-NL.jpg" });
            routes.Add(new Route { id = "X2B", color = Color.FromHex("FF4A18A1"), stops = GetSavedStops(),mapImage = "A2-NL.jpg"} );
            routes.Add(new Route { id = "X2B", color = Color.FromHex("FF4A18A1"), stops = GetSavedStops(), mapImage = "A2-NL.jpg" });
            routes.Add(new Route { id = "X2B", color = Color.FromHex("FF4A18A1"), stops = GetSavedStops(), mapImage = "A2-NL.jpg" });
            routes.Add(new Route { id = "X2B", color = Color.FromHex("FF4A18A1"), stops = GetSavedStops(), mapImage = "A2-NL.jpg" });
            routes.Add(new Route { id = "X2B", color = Color.FromHex("FF4A18A1"), stops = GetSavedStops(), mapImage = "A2-NL.jpg" });
            routes.Add(new Route { id = "X2B", color = Color.FromHex("FF4A18A1"), stops = GetSavedStops(), mapImage = "A2-NL.jpg" });
            routes.Add(new Route { id = "X2B", color = Color.FromHex("FF4A18A1"), stops = GetSavedStops(), mapImage = "A2-NL.jpg" });
            routes.Add(new Route { id = "X2B", color = Color.FromHex("FF4A18A1"), stops = GetSavedStops(), mapImage = "A2-NL.jpg" });
            routes.Add(new Route { id = "X2B", color = Color.FromHex("FF4A18A1"), stops = GetSavedStops(), mapImage = "A2-NL.jpg" });
            routes.Add(new Route { id = "X2B", color = Color.FromHex("FF4A18A1"), stops = GetSavedStops(), mapImage = "A2-NL.jpg" });
            routes.Add(new Route { id = "X2B", color = Color.FromHex("FF4A18A1"), stops = GetSavedStops(), mapImage = "A2-NL.jpg" });
            routes.Add(new Route { id = "X2B", color = Color.FromHex("FF4A18A1"), stops = GetSavedStops(), mapImage = "A2-NL.jpg" });

            return routes;
        }
    }
}
