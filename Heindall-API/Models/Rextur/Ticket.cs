using Heindall_API.Models.Rextur;

namespace Heindall_API.Models.Rextur;

public partial class Ticket
{
	public int Id { get; set; }

	public List<Itinerary> Itineraries { get; set; } 

	public List<Passenger> Passengers { get; set; }

	public List<Carro> Carros { get; set; }

	public List<Onibus> Onibus { get; set; }

	public List<ManagementField> ManagementFields { get; set; }

	public List<Hotel> Hoteis { get; set; }

	public string FormsOfPayment { get; set; }

	public int? AgencyId { get; set; }

	public string AutorizerList { get; set; }

	public string BookClaimer { get; set; } 

	public bool? Capturado { get; set; } 

	public float? CcAmount { get; set; }

	public string CcAuth { get; set; }

	public string CcAuthRav { get; set; }

	public string CcBandeiraRav { get; set; }

	public string CcNum { get; set; }

	public string CcNumRav { get; set; }

	public int? ClaimerId { get; set; }

	public string ClaimerName { get; set; }

	public string ClientCode { get; set; }

	public float? ComissionPercent { get; set; }

	public float? ComissionValue { get; set; }

	public string CompanyFormalName { get; set; }

	public int? CompanyId { get; set; }

	public string CompanyName { get; set; }

	public int? CostCenterId { get; set; }

	public string CostCenterName { get; set; }

	public string Cpf { get; set; }

	public string Currency { get; set; }

	public float? CurrencyValue { get; set; }

	public string Department { get; set; }

	public string Email { get; set; }

	public bool? Emd { get; set; }

	public float? Fare { get; set; }

	public float? FeeBrl { get; set; }

	public float? FeeCliAmount { get; set; }

	public float? FeeTotal { get; set; }

	public string FreeText { get; set; }

	public int? GroupId { get; set; }

	public string GroupName { get; set; }

	public float? Incentive { get; set; }

	public int? Installments { get; set; }

	public DateTime? IssueDate { get; set; }

	public string IssueType { get; set; }

	public string IssuerUser { get; set; }

	public string Loc { get; set; }

	public string NumOp { get; set; }

	public float? OriginalFare { get; set; }

	public string OriginalTktNum { get; set; }

	public string PassengerName { get; set; }

	public string PaxName { get; set; }

	public int? Penalty { get; set; }

	public string ProductType { get; set; }

	public float? Rav { get; set; }

	public string Reason { get; set; }

	public string Status { get; set; }

	public int? TaxaOb { get; set; }

	public string TktNum { get; set; }

	public int? YqTax { get; set; }


}
