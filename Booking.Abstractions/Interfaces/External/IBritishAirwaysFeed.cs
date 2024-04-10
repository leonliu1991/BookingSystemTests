using Booking.Abstractions.DataTransfer.External;

namespace Booking.Abstractions.Interfaces.External;

public interface IBritishAirwaysFeed
{
    IEnumerable<BaFlight> BritishAirwaysFlights { get; }
}