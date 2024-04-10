using Booking.Abstractions.DataTransfer.Internal;

namespace Booking.Abstractions.Interfaces.Internal.Feeds;

public interface IFlightFeed
{
    IEnumerable<IFlight> GetFlights();
}