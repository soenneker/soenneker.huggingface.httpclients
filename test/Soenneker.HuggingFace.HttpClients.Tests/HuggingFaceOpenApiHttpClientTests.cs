using Soenneker.HuggingFace.HttpClients.Abstract;
using Soenneker.Tests.HostedUnit;

namespace Soenneker.HuggingFace.HttpClients.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class HuggingFaceOpenApiHttpClientTests : HostedUnitTest
{
    private readonly IHuggingFaceOpenApiHttpClient _httpclient;

    public HuggingFaceOpenApiHttpClientTests(Host host) : base(host)
    {
        _httpclient = Resolve<IHuggingFaceOpenApiHttpClient>(true);
    }

    [Test]
    public void Default()
    {

    }
}
