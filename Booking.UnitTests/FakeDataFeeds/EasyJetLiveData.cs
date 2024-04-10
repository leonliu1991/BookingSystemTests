using Booking.Abstractions.DataTransfer.External;
using Booking.Abstractions.Interfaces.External;

namespace Booking.UnitTests.FakeDataFeeds;

public class EasyJetLiveData : IEasyJetLiveData
{
    private static readonly IEnumerable<EasyJetDto> Flights;

    static EasyJetLiveData()
    {
        Flights = new[]
        {
                new EasyJetDto { PoundsSterling="42", DepartureAirport="LHR", ArrivalAirport="MUC", International=true, DepartureDate="2017-08-10T06:20:00Z", ArrivalDate="2017-08-10T09:10:00Z" },
                new EasyJetDto { PoundsSterling="59", DepartureAirport="LGW", ArrivalAirport="CDG", International=true, DepartureDate="2017-08-10T08:00:00Z", ArrivalDate="2017-08-10T10:15:00Z" },
                new EasyJetDto { PoundsSterling="62", DepartureAirport="LTN", ArrivalAirport="BCN", International=true, DepartureDate="2017-08-10T17:50:00Z", ArrivalDate="2017-08-10T21:05:00Z" },
                new EasyJetDto { PoundsSterling="45", DepartureAirport="LTN", ArrivalAirport="EDI", International=false, DepartureDate="2017-08-10T14:45:00Z", ArrivalDate="2017-08-10T16:00:00Z" },
                new EasyJetDto { PoundsSterling="81", DepartureAirport="LGW", ArrivalAirport="ATH", International=true, DepartureDate="2017-08-10T05:25:00Z", ArrivalDate="2017-08-10T11:20:00Z" },
                new EasyJetDto { PoundsSterling="67", DepartureAirport="LHR", ArrivalAirport="MAN", International=false, DepartureDate="2017-08-10T08:00:00Z", ArrivalDate="2017-08-10T09:00:00Z" },
                new EasyJetDto { PoundsSterling="42", DepartureAirport="LHR", ArrivalAirport="MUC", International=true, DepartureDate="2017-08-11T06:20:00Z", ArrivalDate="2017-08-11T09:10:00Z" },
                new EasyJetDto { PoundsSterling="59", DepartureAirport="LGW", ArrivalAirport="CDG", International=true, DepartureDate="2017-08-11T08:00:00Z", ArrivalDate="2017-08-11T10:15:00Z" },
                new EasyJetDto { PoundsSterling="62", DepartureAirport="LTN", ArrivalAirport="BCN", International=true, DepartureDate="2017-08-11T17:50:00Z", ArrivalDate="2017-08-11T21:05:00Z" },
                new EasyJetDto { PoundsSterling="45", DepartureAirport="LTN", ArrivalAirport="EDI", International=false, DepartureDate="2017-08-11T14:45:00Z", ArrivalDate="2017-08-11T16:00:00Z" },
                new EasyJetDto { PoundsSterling="81", DepartureAirport="LGW", ArrivalAirport="ATH", International=true, DepartureDate="2017-08-11T05:25:00Z", ArrivalDate="2017-08-11T11:20:00Z" },
                new EasyJetDto { PoundsSterling="67", DepartureAirport="LHR", ArrivalAirport="MAN", International=false, DepartureDate="2017-08-11T08:00:00Z", ArrivalDate="2017-08-11T09:00:00Z" },
                new EasyJetDto { PoundsSterling="42", DepartureAirport="LHR", ArrivalAirport="MUC", International=true, DepartureDate="2017-08-12T06:20:00Z", ArrivalDate="2017-08-12T09:10:00Z" },
                new EasyJetDto { PoundsSterling="59", DepartureAirport="LGW", ArrivalAirport="CDG", International=true, DepartureDate="2017-08-12T08:00:00Z", ArrivalDate="2017-08-12T10:15:00Z" },
                new EasyJetDto { PoundsSterling="62", DepartureAirport="LTN", ArrivalAirport="BCN", International=true, DepartureDate="2017-08-12T17:50:00Z", ArrivalDate="2017-08-12T21:05:00Z" },
                new EasyJetDto { PoundsSterling="45", DepartureAirport="LTN", ArrivalAirport="EDI", International=false, DepartureDate="2017-08-12T14:45:00Z", ArrivalDate="2017-08-12T16:00:00Z" },
                new EasyJetDto { PoundsSterling="81", DepartureAirport="LGW", ArrivalAirport="ATH", International=true, DepartureDate="2017-08-12T05:25:00Z", ArrivalDate="2017-08-12T11:20:00Z" },
                new EasyJetDto { PoundsSterling="67", DepartureAirport="LHR", ArrivalAirport="MAN", International=false, DepartureDate="2017-08-12T08:00:00Z", ArrivalDate="2017-08-12T09:00:00Z" },
                new EasyJetDto { PoundsSterling="42", DepartureAirport="LHR", ArrivalAirport="MUC", International=true, DepartureDate="2017-08-13T06:20:00Z", ArrivalDate="2017-08-13T09:10:00Z" },
                new EasyJetDto { PoundsSterling="59", DepartureAirport="LGW", ArrivalAirport="CDG", International=true, DepartureDate="2017-08-13T08:00:00Z", ArrivalDate="2017-08-13T10:15:00Z" },
                new EasyJetDto { PoundsSterling="62", DepartureAirport="LTN", ArrivalAirport="BCN", International=true, DepartureDate="2017-08-13T17:50:00Z", ArrivalDate="2017-08-13T21:05:00Z" },
                new EasyJetDto { PoundsSterling="45", DepartureAirport="LTN", ArrivalAirport="EDI", International=false, DepartureDate="2017-08-13T14:45:00Z", ArrivalDate="2017-08-13T16:00:00Z" },
                new EasyJetDto { PoundsSterling="81", DepartureAirport="LGW", ArrivalAirport="ATH", International=true, DepartureDate="2017-08-13T05:25:00Z", ArrivalDate="2017-08-13T11:20:00Z" },
                new EasyJetDto { PoundsSterling="67", DepartureAirport="LHR", ArrivalAirport="MAN", International=false, DepartureDate="2017-08-13T08:00:00Z", ArrivalDate="2017-08-13T09:00:00Z" },
                new EasyJetDto { PoundsSterling="42", DepartureAirport="LHR", ArrivalAirport="MUC", International=true, DepartureDate="2017-08-14T06:20:00Z", ArrivalDate="2017-08-14T09:10:00Z" },
                new EasyJetDto { PoundsSterling="59", DepartureAirport="LGW", ArrivalAirport="CDG", International=true, DepartureDate="2017-08-14T08:00:00Z", ArrivalDate="2017-08-14T10:15:00Z" },
                new EasyJetDto { PoundsSterling="62", DepartureAirport="LTN", ArrivalAirport="BCN", International=true, DepartureDate="2017-08-14T17:50:00Z", ArrivalDate="2017-08-14T21:05:00Z" },
                new EasyJetDto { PoundsSterling="45", DepartureAirport="LTN", ArrivalAirport="EDI", International=false, DepartureDate="2017-08-14T14:45:00Z", ArrivalDate="2017-08-14T16:00:00Z" },
                new EasyJetDto { PoundsSterling="81", DepartureAirport="LGW", ArrivalAirport="ATH", International=true, DepartureDate="2017-08-14T05:25:00Z", ArrivalDate="2017-08-14T11:20:00Z" },
                new EasyJetDto { PoundsSterling="67", DepartureAirport="LHR", ArrivalAirport="MAN", International=false, DepartureDate="2017-08-14T08:00:00Z", ArrivalDate="2017-08-14T09:00:00Z" },
            };
    }

    public IEnumerable<EasyJetDto> GetFlights => Flights;
}