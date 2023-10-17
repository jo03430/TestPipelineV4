using Shouldly;
using TestPipelineV4.Domain.Settings;

namespace TestPipelineV4.Domain.Test.Settings;

public class BasicAuthenticationSettingsTests
{
    [Test]
    public void BasicAuthenticationSettingsTest()
    {
        var settings = new BasicAuthenticationSettings
        {
            Token = "abc",
            HashType = "def"
        };
        
        settings.Token.ShouldBe("abc");
        settings.HashType.ShouldBe("def");
    }
}