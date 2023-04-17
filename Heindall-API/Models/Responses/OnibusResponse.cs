using Newtonsoft.Json;
using System;

namespace Heindall_API.Models.Responses;

public class OnibusResponse
{
	[JsonProperty("boardingDate")]
	public DateTime BoardingDate { get; set; }

	[JsonProperty("boardingPlace")]
	public string BoardingPlace { get; set; }

	[JsonProperty("busClass")]
	public string BusClass { get; set; }

	[JsonProperty("busCompanyCode")]
	public int BusCompanyCode { get; set; }

	[JsonProperty("busCompanyName")]
	public string BusCompanyName { get; set; }

	[JsonProperty("landingDate")]
	public DateTime LandingDate { get; set; }

	[JsonProperty("landingPlace")]
	public string LandingPlace { get; set; }
}
