namespace Consumo_API_CSharp.Services;

public sealed class ApiException : Exception
{
    public int? StatusCode { get; }

    public ApiException(string message)
        : base(message)
    {
    }

    public ApiException(string message, int statusCode)
        : base(message)
    {
        StatusCode = statusCode;
    }

    public ApiException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}
