using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;

namespace Soenneker.HuggingFace.HttpClients.Abstract;

/// <summary>
/// Provides a cached HTTP client for the Hugging Face Hub API.
/// </summary>
public interface IHuggingFaceOpenApiHttpClient: IDisposable, IAsyncDisposable
{
    /// <summary>Gets the client configured with HuggingFace:ApiKey and an optional HuggingFace:ClientBaseUrl.</summary>
    ValueTask<HttpClient> Get(CancellationToken cancellationToken = default);
}
