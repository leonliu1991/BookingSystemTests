using Booking.Abstractions.DataTransfer.Internal;
using Booking.Abstractions.Interfaces.External;
using Booking.Abstractions.Interfaces.Internal.Feeds;

namespace Booking.Services.Feeds;

public class FeedEasyJet : IFeedEasyJet
{
    private readonly IEasyJetLiveData _feed;

    public FeedEasyJet(IEasyJetLiveData feed)
    {
        _feed = feed;
    }


    public IEnumerable<IFlight> GetFlights()
    {
        return _feed.GetFlights
            .Select(x =>
            {
                var depart = DateTime.Parse(x.DepartureDate);
                var arrive = DateTime.Parse(x.ArrivalDate);
                return new Flight
                {
                    Airline = Airline.EasyJet,
                    DepartureCode = x.DepartureAirport.ToUpperInvariant(),
                    ArrivalCode = x.ArrivalAirport.ToUpperInvariant(),
                    PriceSterling = decimal.Parse(x.PoundsSterling),
                    DepartureDate = DateOnly.FromDateTime(depart),
                    DepartureTime = TimeOnly.FromDateTime(depart),
                    ArrivalDate = DateOnly.FromDateTime(arrive),
                    ArrivalTime = TimeOnly.FromDateTime(arrive),
                    International = x.International
                };
            });
    }
}