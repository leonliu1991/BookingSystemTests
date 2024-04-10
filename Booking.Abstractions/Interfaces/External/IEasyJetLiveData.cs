using Booking.Abstractions.DataTransfer.External;

namespace Booking.Abstractions.Interfaces.External;

public interface IEasyJetLiveData
{
    IEnumerable<EasyJetDto> GetFlights { get; }
}