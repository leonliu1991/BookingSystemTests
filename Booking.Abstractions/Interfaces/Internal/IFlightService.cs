using Booking.Abstractions.DataTransfer.Internal;

namespace Booking.Abstractions.Interfaces.Internal;

/// <summary>
/// Service providing flight search functionality.
/// </summary>
public interface IFlightService
{
    /// <summary>
    /// Search flight feeds for available flights that meet the search parameters.
    /// </summary>
    /// <param name="options">Search parameters</param>
    /// <returns>List of <see cref="Flight"/> results</returns>
    IEnumerable<IFlight> Search(SearchOptions options);
}