namespace Heindall_API.Models.Rextur;

public class ManagementField
{
	public int Id { get; set; }

	public int? TicketId { get; set; }

	public Ticket Ticket { get; set; }

	public string Chave { get; set; }

	public string NomeCampo { get; set; }

	public string Valor { get; set; }
}
