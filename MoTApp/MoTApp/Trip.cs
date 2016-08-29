using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoTApp
{
    public class Trip
    {
        public string startLocation { get; set; }
        public string endLocation { get; set; }
        public string startStop { get; set; }
        public string endStop { get; set; }
        public double duration { get; set; }
        public int numberOfStops { get; set; }
        public Bus bus { get; set; }
    }

    public class Bus
    {
        public string busID { get; set; }
        public Zone zone { get; set; }
    }

    public class Zone
    {
        public string name { get; set; }
        public double price { get; set; }
    }

    public class TripsManager
    {
        public static List<Trip> GetSavedTrips()
        {
            var trips = new List<Trip>();

            trips.Add(new Trip { startLocation = "Manama", endLocation = "Sitra", startStop = "Main Terminal", endStop = "Gas Station Stop", duration = 20.5, numberOfStops = 1, bus = new Bus { busID = "B1", zone = new Zone { name = "zone 5", price = 200 } } });
            trips.Add(new Trip { startLocation = "Manama", endLocation = "Sitra", startStop = "Main Terminal", endStop = "Gas Station Stop", duration = 20.5, numberOfStops = 1, bus = new Bus { busID = "B1", zone = new Zone { name = "zone 5", price = 200 } } });
            trips.Add(new Trip { startLocation = "Manama", endLocation = "Sitra", startStop = "Main Terminal", endStop = "Gas Station Stop", duration = 20.5, numberOfStops = 1, bus = new Bus { busID = "B1", zone = new Zone { name = "zone 5", price = 200 } } });
            trips.Add(new Trip { startLocation = "Manama", endLocation = "Sitra", startStop = "Main Terminal", endStop = "Gas Station Stop", duration = 20.5, numberOfStops = 1, bus = new Bus { busID = "B1", zone = new Zone { name = "zone 5", price = 200 } } });
            trips.Add(new Trip { startLocation = "Manama", endLocation = "Sitra", startStop = "Main Terminal", endStop = "Gas Station Stop", duration = 20.5, numberOfStops = 1, bus = new Bus { busID = "B1", zone = new Zone { name = "zone 5", price = 200 } } });

            return trips;
        }
    }
}
