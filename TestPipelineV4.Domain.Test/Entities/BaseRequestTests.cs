using Shouldly;
using TestPipelineV4.Domain.Entities;

namespace TestPipelineV4.Domain.Test.Entities;

public class BaseRequestTests
{
    public class TestCase : BaseRequest
    {
        
    }

    [Test]
    public void BaseRequestTest() => new TestCase {CorrelationId = "abc"}.CorrelationId.ShouldBe("abc");
}