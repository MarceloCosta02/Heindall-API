namespace Heindall_API.Models.Rextur;

public class Onibus
{
	public int Id { get; set; }

	public int? TicketId { get; set; }

	public Ticket Ticket { get; set; }

	public DateTime BoardingDate { get; set; }

	public string BoardingPlace { get; set; }

	public string BusClass { get; set; }

	public int BusCompanyCode { get; set; }

	public string BusCompanyName { get; set; }

	public DateTime LandingDate { get; set; }

	public string LandingPlace { get; set; }
}
