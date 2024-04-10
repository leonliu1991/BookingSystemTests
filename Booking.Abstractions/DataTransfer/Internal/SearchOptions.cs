namespace Booking.Abstractions.DataTransfer.Internal;

/// <summary>
/// Available search parameters for flights.
/// </summary>
public class SearchOptions
{
    /// <summary>
    /// Desired departure airport code
    /// </summary>
    public string DepartureCode { get; set; }

    /// <summary>
    /// Desired arrival airport code
    /// </summary>
    public string ArrivalCode { get; set; }

    /// <summary>
    /// Start date and time of desired departure window
    /// </summary>
    public DateTime FromDateTime { get; set; }

    /// <summary>
    /// End date and time of desired departure window
    /// </summary>
    public DateTime ToDateTime { get; set; }

    /// <summary>
    /// TODO: Not implemented
    /// </summary>
    public bool InternationalOnly { get; set; }
}