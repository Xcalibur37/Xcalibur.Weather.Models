namespace Xcalibur.Weather.Models.Testing;

/// Simple handler stub that returns the provided response
/// <summary>
/// 
/// </summary>
/// <seealso cref="System.Net.Http.HttpMessageHandler" />
public sealed class DelegatingHandlerStub : HttpMessageHandler
{
    private readonly HttpResponseMessage _response;

    /// <summary>
    /// Initializes a new instance of the <see cref="DelegatingHandlerStub" /> class.
    /// </summary>
    /// <param name="response">The response.</param>
    public DelegatingHandlerStub(HttpResponseMessage response) => _response = response;

    /// <summary>
    /// Send an HTTP request as an asynchronous operation.
    /// </summary>
    /// <param name="request">The HTTP request message to send.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <returns>
    /// The task object representing the asynchronous operation.
    /// </returns>
    protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        => Task.FromResult(_response);
}