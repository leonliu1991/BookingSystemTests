using Booking.Abstractions.DataTransfer.Internal;
using Booking.Abstractions.Interfaces.Internal;

namespace Booking.Services;

public class FlightService : IFlightService
{
    private readonly IFeedProvider _feeds;

    public FlightService(IFeedProvider feeds)
    {
        _feeds = feeds;
    }

    public IEnumerable<IFlight> Search(SearchOptions options)
    {
        var result = new List<IFlight>();

        foreach (var feed in _feeds.GetFeeds())
        {
            result.AddRange(feed.GetFlights()
                .Where(x => x.DepartureCode == options.DepartureCode.ToUpperInvariant()
                            && x.ArrivalCode == options.ArrivalCode.ToUpperInvariant()
                            && x.DepartureDate >= DateOnly.FromDateTime(options.FromDateTime)
                            && x.DepartureDate <= DateOnly.FromDateTime(options.ToDateTime.AddDays(1))
                )
            );
        }

        return result;
    }
}

