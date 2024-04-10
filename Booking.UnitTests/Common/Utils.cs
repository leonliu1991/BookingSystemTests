using System;
using Booking.Abstractions.DataTransfer.Internal;

namespace Booking.UnitTests.Common
{
	public class Utils
	{
		public static bool IsDepartureDateTimeAcsendingOrder(List<IFlight> flights)
		{
            bool isAscending = true;
            for (int i = 0; i < flights.Count - 1; i++)
            {
                if (flights[i].DepartureDate.ToDateTime(flights[i].DepartureTime) > flights[i+1].DepartureDate.ToDateTime(flights[i+1].DepartureTime))
                {
                    isAscending = false;
                    break;
                }
            }
            return true;
        }
	}
}

