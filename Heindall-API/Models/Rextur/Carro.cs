namespace Heindall_API.Models.Rextur;

public class Carro
{
    public int Id { get; set; }

    public int? TicketId { get; set; }

    public Ticket Ticket { get; set; }

    public string CancellationDeadline { get; set; }

    public string CategoryCode { get; set; }

    public string CategoryTypeCode { get; set; }

    public string CodCia { get; set; }

    public int DeliverShopId { get; set; }

    public string Description { get; set; }

    public string DevolutionDate { get; set; }

    public string NumberOfBaggages { get; set; }

    public string NumberOfPassengers { get; set; }

    public string NumberOfPorts { get; set; }

    public string Provider { get; set; }

    public string ProviderCode { get; set; }

    public string Type { get; set; }

    public string WithdrawalDate { get; set; }

    public int WithdrawalShopId { get; set; }
}
