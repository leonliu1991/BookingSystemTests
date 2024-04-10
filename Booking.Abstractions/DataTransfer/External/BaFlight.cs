namespace Booking.Abstractions.DataTransfer.External;

public class BaFlight
{
    public string AircraftType { get; set; }
    public string Depart { get; set; }
    public string Destination { get; set; }
    public bool International { get; set; }
    public string DepartDate { get; set; }
    public string DepartTime { get; set; }
    public string ArrivalDate { get; set; }
    public string ArrivalTime { get; set; }
    public string PriceSterling { get; set; }
}