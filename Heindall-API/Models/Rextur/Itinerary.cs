namespace Heindall_API.Models.Rextur;

public partial class Itinerary
{
	public int Id { get; set; }

	public int? TicketId { get; set; }

	public Ticket Ticket { get; set; }

	public string AirlineCode { get; set; }

	public DateTime? ArrivalDate { get; set; }

	public string ArrivalTime { get; set; }

	public DateTime? Date { get; set; }

	public string DepartureTime { get; set; }

	public string Destination { get; set; }

	public string FareBase { get; set; }

	public string FlightNumber { get; set; }

	public string Origin { get; set; }

	public string SeatClass { get; set; }
}
