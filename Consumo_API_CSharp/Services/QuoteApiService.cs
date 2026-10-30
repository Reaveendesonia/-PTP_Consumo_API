using System.Text.Json;
using Consumo_API_CSharp.Models;

namespace Consumo_API_CSharp.Services;

public sealed class QuoteApiService : IDisposable
{
    private const string BaseUrl = "https://dummyjson.com/";
    private const int TimeoutSeconds = 20;

    private static readonly JsonSerializerOptions JsonOptions = new()
    {
        PropertyNameCaseInsensitive = true
    };

    private readonly HttpClient _httpClient;
    private IReadOnlyList<Quote>? _allQuotesCache;

    public QuoteApiService()
        : this(new HttpClient())
    {
    }

    public QuoteApiService(HttpClient httpClient)
    {
        _httpClient = httpClient;
        _httpClient.BaseAddress = new Uri(BaseUrl);
        _httpClient.Timeout = TimeSpan.FromSeconds(TimeoutSeconds);
        _httpClient.DefaultRequestHeaders.Accept.ParseAdd("application/json");
        _httpClient.DefaultRequestHeaders.UserAgent.ParseAdd("Consumo_API_CSharp/1.0");
    }

    public async Task<Quote> GetQuoteByIdAsync(int id, CancellationToken cancellationToken = default)
    {
        try
        {
            return await GetAsync<Quote>($"quotes/{id}", cancellationToken);
        }
        catch (ApiException ex) when (ex.StatusCode == 404)
        {
            throw new ApiException($"Citação com o ID {id} não foi encontrada na API.", 404);
        }
    }

    public Task<Quote> GetRandomQuoteAsync(CancellationToken cancellationToken = default)
    {
        return GetAsync<Quote>("quotes/random", cancellationToken);
    }

    public Task<QuotesResponse> GetQuotesAsync(int limit, int skip, CancellationToken cancellationToken = default)
    {
        return GetAsync<QuotesResponse>($"quotes?limit={limit}&skip={skip}", cancellationToken);
    }

    public async Task<IReadOnlyList<Quote>> SearchQuotesAsync(string term, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(term))
        {
            return Array.Empty<Quote>();
        }

        if (_allQuotesCache is null)
        {
            QuotesResponse allQuotes = await GetAsync<QuotesResponse>("quotes?limit=0", cancellationToken);
            _allQuotesCache = allQuotes.Quotes;
        }

        string value = term.Trim();

        return _allQuotesCache
            .Where(quote => quote.Author.Contains(value, StringComparison.OrdinalIgnoreCase)
                            || quote.Text.Contains(value, StringComparison.OrdinalIgnoreCase))
            .ToList();
    }

    private async Task<T> GetAsync<T>(string relativeUrl, CancellationToken cancellationToken)
    {
        using HttpResponseMessage response = await _httpClient.GetAsync(relativeUrl, cancellationToken);
        string content = await response.Content.ReadAsStringAsync(cancellationToken);

        if (!response.IsSuccessStatusCode)
        {
            string message = ExtractErrorMessage(content)
                             ?? $"A API respondeu com o estado {(int)response.StatusCode} ({response.ReasonPhrase}).";

            throw new ApiException(message, (int)response.StatusCode);
        }

        try
        {
            return JsonSerializer.Deserialize<T>(content, JsonOptions)
                   ?? throw new ApiException("A API devolveu uma resposta vazia.");
        }
        catch (JsonException ex)
        {
            throw new ApiException("Não foi possível interpretar a resposta JSON devolvida pela API.", ex);
        }
    }

    private static string? ExtractErrorMessage(string content)
    {
        try
        {
            using JsonDocument document = JsonDocument.Parse(content);

            if (document.RootElement.ValueKind == JsonValueKind.Object
                && document.RootElement.TryGetProperty("message", out JsonElement message)
                && message.ValueKind == JsonValueKind.String)
            {
                return message.GetString();
            }
        }
        catch (JsonException)
        {
        }

        return null;
    }

    public void Dispose()
    {
        _httpClient.Dispose();
    }
}
