namespace Booking.Abstractions.DataTransfer.External;

public class EasyJetDto
{
    public bool International { get; set; }
    public string DepartureAirport { get; set; }
    public string DepartureDate { get; set; }
    public string ArrivalAirport { get; set; }
    public string ArrivalDate { get; set; }
    public string PoundsSterling { get; set; }
}