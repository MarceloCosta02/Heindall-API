using Heindall_API.Models.Responses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Heindall_API.Models.Responses;

public class TicketsResponse
{
	[JsonProperty("bookClaimer")]
	public string BookClaimer { get; set; }

	[JsonProperty("capturado")]
	public bool Capturado { get; set; }

	[JsonProperty("carro")]
	public List<CarroResponse> Carros { get; set; }

	[JsonProperty("ccAmount")]
	public float? CcAmount { get; set; }

	[JsonProperty("ccAuth")]
	public string CcAuth { get; set; }

	[JsonProperty("ccAuthRav")]
	public string CcAuthRav { get; set; }

	[JsonProperty("ccBandeiraRav")]
	public string CcBandeiraRav { get; set; }

	[JsonProperty("ccNum")]
	public string CcNum { get; set; }

	[JsonProperty("ccNumRav")]
	public string CcNumRav { get; set; }

	[JsonProperty("claimerId")]
	public int ClaimerId { get; set; }

	[JsonProperty("claimerName")]
	public string ClaimerName { get; set; }

	[JsonProperty("clientCode")]
	public string ClientCode { get; set; }

	[JsonProperty("comissionPercent")]
	public float ComissionPercent { get; set; }

	[JsonProperty("comissionValue")]
	public float ComissionValue { get; set; }

	[JsonProperty("companyFormalName")]
	public string CompanyFormalName { get; set; }

	[JsonProperty("companyId")]
	public int CompanyId { get; set; }

	[JsonProperty("companyName")]
	public string CompanyName { get; set; }

	[JsonProperty("costCenterId")]
	public int CostCenterId { get; set; }

	[JsonProperty("costCenterName")]
	public string CostCenterName { get; set; }

	[JsonProperty("cpf")]
	public string Cpf { get; set; }

	[JsonProperty("currency")]
	public string Currency { get; set; }

	[JsonProperty("currencyValue")]
	public float? CurrencyValue { get; set; }

	[JsonProperty("department")]
	public string Department { get; set; }

	[JsonProperty("email")]
	public string Email { get; set; }

	[JsonProperty("emd")]
	public bool Emd { get; set; }

	[JsonProperty("fare")]
	public float? Fare { get; set; }

	[JsonProperty("feeBRL")]
	public float? FeeBRL { get; set; }

	[JsonProperty("feeCliAmount")]
	public float? FeeCliAmount { get; set; }

	[JsonProperty("feeTotal")]
	public float? FeeTotal { get; set; }

	[JsonProperty("formOfPaymentList")]
	public List<string> FormsOfPayment { get; set; }

	[JsonProperty("freeText")]
	public string FreeText { get; set; }

	[JsonProperty("groupId")]
	public int GroupId { get; set; }

	[JsonProperty("groupName")]
	public string GroupName { get; set; }

	[JsonProperty("hotelList")]
	public List<HotelList> Hoteis { get; set; }

	[JsonProperty("incentive")]
	public float? Incentive { get; set; }

	[JsonProperty("installments")]
	public int Installments { get; set; }

	[JsonProperty("issueDate")]
	public DateTime IssueDate { get; set; }

	[JsonProperty("issueType")]
	public string IssueType { get; set; }

	[JsonProperty("issuerUser")]
	public string IssuerUser { get; set; }

	[JsonProperty("itineraryList")]
	public List<ItineraryListResponse> Itineraries { get; set; }

	[JsonProperty("loc")]
	public string Loc { get; set; }

	[JsonProperty("managementFieldList")]
	public List<ManagementFieldListResponse> ManagementFields { get; set; }

	[JsonProperty("numOP")]
	public string NumOP { get; set; }

	[JsonProperty("onibus")]
	public List<OnibusResponse> Onibus { get; set; }

	[JsonProperty("originalFare")]
	public float? OriginalFare { get; set; }

	[JsonProperty("originalTktNum")]
	public string OriginalTktNum { get; set; }

	[JsonProperty("passengerList")]
	public List<PassengerListResponse> Passengers { get; set; }

	[JsonProperty("passengerName")]
	public string PassengerName { get; set; }

	[JsonProperty("paxName")]
	public string PaxName { get; set; }

	[JsonProperty("penalty")]
	public float? Penalty { get; set; }

	[JsonProperty("productType")]
	public string ProductType { get; set; }

	[JsonProperty("rav")]
	public float? Rav { get; set; }

	[JsonProperty("reason")]
	public string Reason { get; set; }

	[JsonProperty("status")]
	public string Status { get; set; }

	[JsonProperty("taxaOb")]
	public float TaxaOb { get; set; }

	[JsonProperty("tktNum")]
	public string TktNum { get; set; }

	[JsonProperty("yqTax")]
	public float? YqTax { get; set; }

}
