using Shouldly;
using TestPipelineV4.Domain.Settings;

namespace TestPipelineV4.Domain.Test.Settings;

public class DatabaseSettingsTests
{
    [Test]
    public void DatabaseConnectionTest() => new DatabaseSettings
    {
        DatabaseConnection1 = "abc"
    }.DatabaseConnection1.ShouldBe("abc");
}