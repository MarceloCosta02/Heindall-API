namespace Heindall_API.Models.Rextur;

public class Hotel
{
	public int Id { get; set; }

	public int? TicketId { get; set; }

	public Ticket Ticket { get; set; }

	public string AccomodationDescription { get; set; }

	public string Address { get; set; }

	public string BoardType { get; set; }

	public string CategoryType { get; set; }

	public DateTime CheckInDate { get; set; }

	public DateTime CheckOut { get; set; }

	public string City { get; set; }

	public string Country { get; set; }

	public string HotelChain { get; set; }

	public string HotelName { get; set; }

	public int NumberOfAdults { get; set; }

	public int NumberOfChild { get; set; }

	public string PhoneNumber { get; set; }

	public string RoomType { get; set; }

	public string State { get; set; }

	public string SupplierId { get; set; }
}
