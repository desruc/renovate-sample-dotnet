using FluentAssertions;
using Xunit;

namespace SampleApp.Tests;

public class GreeterTests
{
    [Fact]
    public void GreetsByName() => Greeter.Greet("World").Should().Contain("Hello, World!");
}
