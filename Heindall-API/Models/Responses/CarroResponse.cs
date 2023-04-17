using Newtonsoft.Json;

namespace Heindall_API.Models.Responses;

public class CarroResponse
{
    [JsonProperty("cancellationDeadline")]
    public string CancellationDeadline { get; set; }

    [JsonProperty("categoryCode")]
    public string CategoryCode { get; set; }

    [JsonProperty("categoryTypeCode")]
    public string CategoryTypeCode { get; set; }

    [JsonProperty("codCia")]
    public string CodCia { get; set; }

    [JsonProperty("deliverShopId")]
    public int DeliverShopId { get; set; }

    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonProperty("devolutionDate")]
    public string DevolutionDate { get; set; }

    [JsonProperty("numberOfBaggages")]
    public string NumberOfBaggages { get; set; }

    [JsonProperty("numberOfPassengers")]
    public string NumberOfPassengers { get; set; }

    [JsonProperty("numberOfPorts")]
    public string NumberOfPorts { get; set; }

    [JsonProperty("provider")]
    public string Provider { get; set; }

    [JsonProperty("providerCode")]
    public string ProviderCode { get; set; }

    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("withdrawalDate")]
    public string WithdrawalDate { get; set; }

    [JsonProperty("withdrawalShopId")]
    public int WithdrawalShopId { get; set; }
}
