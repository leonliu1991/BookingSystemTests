using Booking.Abstractions.Interfaces.Internal;
using Booking.Abstractions.Interfaces.Internal.Feeds;

namespace Booking.Services;

public class FeedProvider : IFeedProvider
{
    private readonly IFeedBritishAirways _britishAirways;
    private readonly IFeedEasyJet _easyJet;

    public FeedProvider(IFeedBritishAirways britishAirways,
        IFeedEasyJet easyJet)
    {
        _britishAirways = britishAirways;
        _easyJet = easyJet;
    }

    public IEnumerable<IFlightFeed> GetFeeds()
    {
        return new List<IFlightFeed>
        {
            _britishAirways,
            _easyJet
        };
    }
}