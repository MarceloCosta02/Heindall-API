namespace Heindall_API.Models.Rextur;

public partial class Passenger
{
	public int Id { get; set; }

	public int? TicketId { get; set; }

	public Ticket Ticket { get; set; }

	public int? PaxId { get; set; }

	public string PaxName { get; set; }

	public string PaxMiddleName { get; set; }

	public string PaxLastName { get; set; }

	public string FaixaEtaria { get; set; }

	public DateTime? BirthDate { get; set; }

	public string Gender { get; set; }

	public string Cpf { get; set; }

	public string Rg { get; set; }

	public string Passport { get; set; }

	public string Redress { get; set; }

	public string Email { get; set; }

	public string Phone { get; set; }

	public string Ddd { get; set; }
}
