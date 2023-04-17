using Newtonsoft.Json;
using System;

namespace Heindall_API.Models.Responses;

public class HotelList
{
	[JsonProperty("accomodationDescription")]
	public string AccomodationDescription { get; set; }

	[JsonProperty("address")]
	public string Address { get; set; }

	[JsonProperty("boardType")]
	public string BoardType { get; set; }

	[JsonProperty("categoryType")]
	public string CategoryType { get; set; }

	[JsonProperty("checkInDate")]
	public DateTime CheckInDate { get; set; }

	[JsonProperty("checkOut")]
	public DateTime CheckOut { get; set; }

	[JsonProperty("city")]
	public string City { get; set; }

	[JsonProperty("country")]
	public string Country { get; set; }

	[JsonProperty("hotelChain")]
	public string HotelChain { get; set; }

	[JsonProperty("hotelName")]
	public string HotelName { get; set; }

	[JsonProperty("numberOfAdults")]
	public int NumberOfAdults { get; set; }

	[JsonProperty("numberOfChild")]
	public int NumberOfChild { get; set; }

	[JsonProperty("phoneNumber")]
	public string PhoneNumber { get; set; }

	[JsonProperty("roomType")]
	public string RoomType { get; set; }

	[JsonProperty("state")]
	public string State { get; set; }

	[JsonProperty("supplierId")]
	public string SupplierId { get; set; }
}
