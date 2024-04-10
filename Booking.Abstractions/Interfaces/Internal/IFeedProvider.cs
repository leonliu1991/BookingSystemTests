using Booking.Abstractions.Interfaces.Internal.Feeds;

namespace Booking.Abstractions.Interfaces.Internal;

public interface IFeedProvider
{
    IEnumerable<IFlightFeed> GetFeeds();
}