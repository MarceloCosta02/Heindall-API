using Newtonsoft.Json;
using System;

namespace Heindall_API.Models.Responses;

public class ItineraryListResponse
{
	[JsonProperty("airlineCode")]
	public string AirlineCode { get; set; }

	[JsonProperty("arrivalDate")]
	public DateTime? ArrivalDate { get; set; }

	[JsonProperty("arrivalTime")]
	public string ArrivalTime { get; set; }

	[JsonProperty("date")]
	public DateTime? Date { get; set; }

	[JsonProperty("departureTime")]
	public string DepartureTime { get; set; }

	[JsonProperty("destination")]
	public string Destination { get; set; }

	[JsonProperty("fareBase")]
	public string FareBase { get; set; }

	[JsonProperty("flightNumber")]
	public string FlightNumber { get; set; }

	[JsonProperty("origin")]
	public string Origin { get; set; }

	[JsonProperty("seatClass")]
	public string SeatClass { get; set; }
}
