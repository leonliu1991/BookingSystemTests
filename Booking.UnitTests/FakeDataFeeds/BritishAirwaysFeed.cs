using Booking.Abstractions.DataTransfer.External;
using Booking.Abstractions.Interfaces.External;

namespace Booking.UnitTests.FakeDataFeeds;

public class BritishAirwaysFeed : IBritishAirwaysFeed
{
    private static readonly IEnumerable<BaFlight> Flights;

    static BritishAirwaysFeed()
    {
        Flights = new[]
        {
                new BaFlight { AircraftType="Boeing 787-8", PriceSterling="150", Depart="LHR", Destination="MUC", International=true, DepartDate="10/08/2017", DepartTime="07:25", ArrivalDate="10/08/2017", ArrivalTime="09:00" },
                new BaFlight { AircraftType="Airbus 321-200", PriceSterling="98", Depart="LGW", Destination="CDG", International=true, DepartDate="10/08/2017", DepartTime="19:30", ArrivalDate="10/08/2017", ArrivalTime="21:40" },
                new BaFlight { AircraftType="Boeing 767-300", PriceSterling="178", Depart="LGW", Destination="BCN", International=true, DepartDate="10/08/2017", DepartTime="16:30", ArrivalDate="10/08/2017", ArrivalTime="19:35" },
                new BaFlight { AircraftType="Airbus 319-300", PriceSterling="71", Depart="LCY", Destination="EDI", International=false, DepartDate="10/08/2017", DepartTime="20:15", ArrivalDate="10/08/2017", ArrivalTime="21:30" },
                new BaFlight { AircraftType="Boeing A380", PriceSterling="480", Depart="LGW", Destination="JFK", International=true, DepartDate="10/08/2017", DepartTime="17:00", ArrivalDate="10/08/2017", ArrivalTime="19:50" },
                new BaFlight { AircraftType="Boeing A380", PriceSterling="385", Depart="LGW", Destination="DXB", International=true, DepartDate="10/08/2017", DepartTime="20:20", ArrivalDate="11/08/2017", ArrivalTime="07:05" },
                new BaFlight { AircraftType="Boeing 767-300", PriceSterling="206", Depart="LHR", Destination="ATH", International=true, DepartDate="10/08/2017", DepartTime="19:25", ArrivalDate="11/08/2017", ArrivalTime="00:55" },
                new BaFlight { AircraftType="Airbus 321-200", PriceSterling="100", Depart="LCY", Destination="EXT", International=false, DepartDate="10/08/2017", DepartTime="20:10", ArrivalDate="10/08/2017", ArrivalTime="21:20" },
                new BaFlight { AircraftType="Boeing A380", PriceSterling="1445", Depart="LHR", Destination="SEA", International=true, DepartDate="10/08/2017", DepartTime="09:20", ArrivalDate="10/08/2017", ArrivalTime="11:15" },
                new BaFlight { AircraftType="Boeing 787-8", PriceSterling="150", Depart="LHR", Destination="MUC", International=true, DepartDate="11/08/2017", DepartTime="07:25", ArrivalDate="11/08/2017", ArrivalTime="09:00" },
                new BaFlight { AircraftType="Airbus 321-200", PriceSterling="98", Depart="LGW", Destination="CDG", International=true, DepartDate="11/08/2017", DepartTime="19:30", ArrivalDate="11/08/2017", ArrivalTime="21:40" },
                new BaFlight { AircraftType="Boeing 767-300", PriceSterling="178", Depart="LGW", Destination="BCN", International=true, DepartDate="11/08/2017", DepartTime="16:30", ArrivalDate="11/08/2017", ArrivalTime="19:35" },
                new BaFlight { AircraftType="Airbus 319-300", PriceSterling="71", Depart="LCY", Destination="EDI", International=false, DepartDate="11/08/2017", DepartTime="20:15", ArrivalDate="11/08/2017", ArrivalTime="21:30" },
                new BaFlight { AircraftType="Boeing A380", PriceSterling="480", Depart="LGW", Destination="JFK", International=true, DepartDate="11/08/2017", DepartTime="17:00", ArrivalDate="11/08/2017", ArrivalTime="19:50" },
                new BaFlight { AircraftType="Boeing A380", PriceSterling="385", Depart="LGW", Destination="DXB", International=true, DepartDate="11/08/2017", DepartTime="20:20", ArrivalDate="12/08/2017", ArrivalTime="07:05" },
                new BaFlight { AircraftType="Boeing 767-300", PriceSterling="206", Depart="LHR", Destination="ATH", International=true, DepartDate="11/08/2017", DepartTime="19:25", ArrivalDate="12/08/2017", ArrivalTime="00:55" },
                new BaFlight { AircraftType="Airbus 321-200", PriceSterling="100", Depart="LCY", Destination="EXT", International=false, DepartDate="11/08/2017", DepartTime="20:10", ArrivalDate="11/08/2017", ArrivalTime="21:20" },
                new BaFlight { AircraftType="Boeing A380", PriceSterling="1445", Depart="LHR", Destination="SEA", International=true, DepartDate="11/08/2017", DepartTime="09:20", ArrivalDate="11/08/2017", ArrivalTime="11:15" },
                new BaFlight { AircraftType="Boeing 787-8", PriceSterling="150", Depart="LHR", Destination="MUC", International=true, DepartDate="12/08/2017", DepartTime="07:25", ArrivalDate="12/08/2017", ArrivalTime="09:00" },
                new BaFlight { AircraftType="Airbus 321-200", PriceSterling="98", Depart="LGW", Destination="CDG", International=true, DepartDate="12/08/2017", DepartTime="19:30", ArrivalDate="12/08/2017", ArrivalTime="21:40" },
                new BaFlight { AircraftType="Boeing 767-300", PriceSterling="178", Depart="LGW", Destination="BCN", International=true, DepartDate="12/08/2017", DepartTime="16:30", ArrivalDate="12/08/2017", ArrivalTime="19:35" },
                new BaFlight { AircraftType="Airbus 319-300", PriceSterling="71", Depart="LCY", Destination="EDI", International=false, DepartDate="12/08/2017", DepartTime="20:15", ArrivalDate="12/08/2017", ArrivalTime="21:30" },
                new BaFlight { AircraftType="Boeing A380", PriceSterling="480", Depart="LGW", Destination="JFK", International=true, DepartDate="12/08/2017", DepartTime="17:00", ArrivalDate="12/08/2017", ArrivalTime="19:50" },
                new BaFlight { AircraftType="Boeing A380", PriceSterling="385", Depart="LGW", Destination="DXB", International=true, DepartDate="12/08/2017", DepartTime="20:20", ArrivalDate="13/08/2017", ArrivalTime="07:05" },
                new BaFlight { AircraftType="Boeing 767-300", PriceSterling="206", Depart="LHR", Destination="ATH", International=true, DepartDate="12/08/2017", DepartTime="19:25", ArrivalDate="13/08/2017", ArrivalTime="00:55" },
                new BaFlight { AircraftType="Airbus 321-200", PriceSterling="100", Depart="LCY", Destination="EXT", International=false, DepartDate="12/08/2017", DepartTime="20:10", ArrivalDate="12/08/2017", ArrivalTime="21:20" },
                new BaFlight { AircraftType="Boeing A380", PriceSterling="1445", Depart="LHR", Destination="SEA", International=true, DepartDate="12/08/2017", DepartTime="09:20", ArrivalDate="12/08/2017", ArrivalTime="11:15" },
                new BaFlight { AircraftType="Boeing 787-8", PriceSterling="150", Depart="LHR", Destination="MUC", International=true, DepartDate="13/08/2017", DepartTime="07:25", ArrivalDate="13/08/2017", ArrivalTime="09:00" },
                new BaFlight { AircraftType="Airbus 321-200", PriceSterling="98", Depart="LGW", Destination="CDG", International=true, DepartDate="13/08/2017", DepartTime="19:30", ArrivalDate="13/08/2017", ArrivalTime="21:40" },
                new BaFlight { AircraftType="Boeing 767-300", PriceSterling="178", Depart="LGW", Destination="BCN", International=true, DepartDate="13/08/2017", DepartTime="16:30", ArrivalDate="13/08/2017", ArrivalTime="19:35" },
                new BaFlight { AircraftType="Airbus 319-300", PriceSterling="71", Depart="LCY", Destination="EDI", International=false, DepartDate="13/08/2017", DepartTime="20:15", ArrivalDate="13/08/2017", ArrivalTime="21:30" },
                new BaFlight { AircraftType="Boeing A380", PriceSterling="480", Depart="LGW", Destination="JFK", International=true, DepartDate="13/08/2017", DepartTime="17:00", ArrivalDate="13/08/2017", ArrivalTime="19:50" },
                new BaFlight { AircraftType="Boeing A380", PriceSterling="385", Depart="LGW", Destination="DXB", International=true, DepartDate="13/08/2017", DepartTime="20:20", ArrivalDate="14/08/2017", ArrivalTime="07:05" },
                new BaFlight { AircraftType="Boeing 767-300", PriceSterling="206", Depart="LHR", Destination="ATH", International=true, DepartDate="13/08/2017", DepartTime="19:25", ArrivalDate="14/08/2017", ArrivalTime="00:55" },
                new BaFlight { AircraftType="Airbus 321-200", PriceSterling="100", Depart="LCY", Destination="EXT", International=false, DepartDate="13/08/2017", DepartTime="20:10", ArrivalDate="13/08/2017", ArrivalTime="21:20" },
                new BaFlight { AircraftType="Boeing A380", PriceSterling="1445", Depart="LHR", Destination="SEA", International=true, DepartDate="13/08/2017", DepartTime="09:20", ArrivalDate="13/08/2017", ArrivalTime="11:15" },
                new BaFlight { AircraftType="Boeing 787-8", PriceSterling="150", Depart="LHR", Destination="MUC", International=true, DepartDate="14/08/2017", DepartTime="07:25", ArrivalDate="14/08/2017", ArrivalTime="09:00" },
                new BaFlight { AircraftType="Airbus 321-200", PriceSterling="98", Depart="LGW", Destination="CDG", International=true, DepartDate="14/08/2017", DepartTime="19:30", ArrivalDate="14/08/2017", ArrivalTime="21:40" },
                new BaFlight { AircraftType="Boeing 767-300", PriceSterling="178", Depart="LGW", Destination="BCN", International=true, DepartDate="14/08/2017", DepartTime="16:30", ArrivalDate="14/08/2017", ArrivalTime="19:35" },
                new BaFlight { AircraftType="Airbus 319-300", PriceSterling="71", Depart="LCY", Destination="EDI", International=false, DepartDate="14/08/2017", DepartTime="20:15", ArrivalDate="14/08/2017", ArrivalTime="21:30" },
                new BaFlight { AircraftType="Boeing A380", PriceSterling="480", Depart="LGW", Destination="JFK", International=true, DepartDate="14/08/2017", DepartTime="17:00", ArrivalDate="14/08/2017", ArrivalTime="19:50" },
                new BaFlight { AircraftType="Boeing A380", PriceSterling="385", Depart="LGW", Destination="DXB", International=true, DepartDate="14/08/2017", DepartTime="20:20", ArrivalDate="15/08/2017", ArrivalTime="07:05" },
                new BaFlight { AircraftType="Boeing 767-300", PriceSterling="206", Depart="LHR", Destination="ATH", International=true, DepartDate="14/08/2017", DepartTime="19:25", ArrivalDate="15/08/2017", ArrivalTime="00:55" },
                new BaFlight { AircraftType="Airbus 321-200", PriceSterling="100", Depart="LCY", Destination="EXT", International=false, DepartDate="14/08/2017", DepartTime="20:10", ArrivalDate="14/08/2017", ArrivalTime="21:20" },
                new BaFlight { AircraftType="Boeing A380", PriceSterling="1445", Depart="LHR", Destination="SEA", International=true, DepartDate="14/08/2017", DepartTime="09:20", ArrivalDate="14/08/2017", ArrivalTime="11:15" },
            };
    }

    public IEnumerable<BaFlight> BritishAirwaysFlights => Flights;

}