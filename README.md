# About

A developer has written server code for part of an online flight booking system. You are to write tests against the implementation to prove it has been suitably implemented and meets all criteria.

There is no database work required – data for unit-tests is already provided via two fake data feeds which span a five-day departure date period from 10/08/2017 to 14/08/2017.

The fake feed interfaces and types match the real feeds used by the booking system implementation.

Although the feeds only contain a small sub-set of data, it’s enough to use as the inputs to the system for you to write tests against.

You are not expected to produce a complete, commercial-level solution - a simple fulfilment of the requirements will suffice.

Any extensions to - or missing - functionality/implementations/designs can be discussed at the end of the exercise.


# Requirements

The requirements as given to the developer:

The flight booking system uses external data feeds from different airlines.
The airline feeds have different interfaces and use their own data formats.
  - All data feed times are UTC
  - All data feed prices are in pounds sterling

The server needs to perform a search and return a single list of matching flights for a specified departure airport code, destination airport code, and date/time from and to range (in local time).
  - The server should only return international flights
  - All time parameters passed to the server are local time

The resultant list of flights should be ordered by price and then departure date/time in ascending order.
The results list should only contain these columns:
  - Airline
  - Departure airport code
  - Departure date
  - Departure time
  - Arrival airport code
  - Arrival date
  - Arrival time
  - Price sterling
