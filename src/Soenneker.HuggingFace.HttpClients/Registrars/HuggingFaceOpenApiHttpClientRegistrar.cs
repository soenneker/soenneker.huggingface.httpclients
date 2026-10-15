using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Soenneker.HuggingFace.HttpClients.Abstract;
using Soenneker.Utils.HttpClientCache.Registrar;

namespace Soenneker.HuggingFace.HttpClients.Registrars;

/// <summary>
/// Registers the OpenAPI HttpClient wrapper for dependency injection.
/// </summary>
public static class HuggingFaceOpenApiHttpClientRegistrar
{
    /// <summary>
    /// Adds <see cref="HuggingFaceOpenApiHttpClient"/> as a singleton service. <para/>
    /// </summary>
    public static IServiceCollection AddHuggingFaceOpenApiHttpClientAsSingleton(this IServiceCollection services)
    {
        services.AddHttpClientCacheAsSingleton()
                .TryAddSingleton<IHuggingFaceOpenApiHttpClient, HuggingFaceOpenApiHttpClient>();

        return services;
    }

    /// <summary>
    /// Adds <see cref="HuggingFaceOpenApiHttpClient"/> as a scoped service. <para/>
    /// </summary>
    public static IServiceCollection AddHuggingFaceOpenApiHttpClientAsScoped(this IServiceCollection services)
    {
        services.AddHttpClientCacheAsSingleton()
                .TryAddScoped<IHuggingFaceOpenApiHttpClient, HuggingFaceOpenApiHttpClient>();

        return services;
    }
}
