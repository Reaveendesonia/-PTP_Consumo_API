using System.Text.Json.Serialization;

namespace Consumo_API_CSharp.Models;

public sealed class QuotesResponse
{
    [JsonPropertyName("quotes")]
    public List<Quote> Quotes { get; set; } = new();

    [JsonPropertyName("total")]
    public int Total { get; set; }

    [JsonPropertyName("skip")]
    public int Skip { get; set; }

    [JsonPropertyName("limit")]
    public int Limit { get; set; }
}
