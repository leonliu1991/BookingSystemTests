namespace Booking.Abstractions.DataTransfer.Internal;

/// <summary>
/// Search result item for a flight search.
/// </summary>
public interface IFlight
{
    /// <summary>
    /// The airline providing the flight
    /// </summary>
    Airline Airline { get; set; }

    /// <summary>
    /// The departure airport code
    /// </summary>
    string DepartureCode { get; set; }
    /// <summary>
    /// The date of departure in UTC
    /// </summary>
    DateOnly DepartureDate { get; set; }
    /// <summary>
    /// The time of departure in UTC
    /// </summary>
    TimeOnly DepartureTime { get; set; }

    /// <summary>
    /// The arrival airport code
    /// </summary>
    string ArrivalCode { get; set; }
    /// <summary>
    /// The date of arrival in UTC
    /// </summary>
    DateOnly ArrivalDate { get; set; }
    /// <summary>
    /// The time of arrival in UTC
    /// </summary>
    TimeOnly ArrivalTime { get; set; }

    /// <summary>
    /// The price of the flight in GBP
    /// </summary>
    decimal PriceSterling { get; set; }

    /// <summary>
    /// The flight is an international flight or not
    /// </summary>
    bool International { get; set; }
}



public class Flight : IFlight
{
    public Airline Airline { get; set; }
    public string DepartureCode { get; set; }
    public DateOnly DepartureDate { get; set; }
    public TimeOnly DepartureTime { get; set; }
    public string ArrivalCode { get; set; }
    public DateOnly ArrivalDate { get; set; }
    public TimeOnly ArrivalTime { get; set; }
    public decimal PriceSterling { get; set; }
    public bool International { get; set; }
}