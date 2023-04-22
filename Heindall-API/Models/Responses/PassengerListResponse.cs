using Newtonsoft.Json;
using System;

namespace Heindall_API.Models.Responses;

public class PassengerListResponse
{
	[JsonProperty("paxId")]
	public int? PaxId { get; set; }

	[JsonProperty("paxName")]
	public string PaxName { get; set; }

	[JsonProperty("paxMiddleName")]
	public string PaxMiddleName { get; set; }

	[JsonProperty("paxLastName")]
	public string PaxLastName { get; set; }

	[JsonProperty("faixaEtaria")]
	public string FaixaEtaria { get; set; }

	[JsonProperty("birthDate")]
	public DateTime? BirthDate { get; set; }

	[JsonProperty("gender")]
	public string Gender { get; set; }

	[JsonProperty("cpf")]
	public string Cpf { get; set; }

	[JsonProperty("rg")]
	public string Rg { get; set; }

	[JsonProperty("passport")]
	public string Passport { get; set; }

	[JsonProperty("redress")]
	public string Redress { get; set; }

	[JsonProperty("email")]
	public string Email { get; set; }

	[JsonProperty("phone")]
	public string Phone { get; set; }

	[JsonProperty("ddd")]
	public string Ddd { get; set; }
}

