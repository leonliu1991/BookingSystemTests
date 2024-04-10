using System.Globalization;
using Booking.Abstractions.DataTransfer.Internal;
using Booking.Abstractions.Interfaces.External;
using Booking.Abstractions.Interfaces.Internal.Feeds;

namespace Booking.Services.Feeds;

public class FeedBritishAirways : IFeedBritishAirways
{
    private readonly IBritishAirwaysFeed _feed;

    public FeedBritishAirways(IBritishAirwaysFeed feed)
    {
        _feed = feed;
    }

    public IEnumerable<IFlight> GetFlights()
    {
        return _feed.BritishAirwaysFlights
            .Select(x =>
            {
                var depart = DateTime.ParseExact($"{x.DepartDate} {x.DepartTime}", "dd/MM/yyyy HH:mm", CultureInfo.CurrentCulture);
                var arrive = DateTime.ParseExact($"{x.ArrivalDate} {x.ArrivalTime}", "dd/MM/yyyy HH:mm", CultureInfo.CurrentCulture);
                return new Flight
                {
                    Airline = Airline.BritishAirways,
                    DepartureCode = x.Depart.ToUpperInvariant(),
                    ArrivalCode = x.Destination.ToUpperInvariant(),
                    PriceSterling = decimal.Parse(x.PriceSterling),
                    DepartureDate = DateOnly.FromDateTime(depart),
                    DepartureTime = TimeOnly.FromDateTime(depart),
                    ArrivalDate = DateOnly.FromDateTime(arrive),
                    ArrivalTime = TimeOnly.FromDateTime(arrive),
                    International = x.International
                };
            });
    }
}