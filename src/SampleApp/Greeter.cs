using Newtonsoft.Json;

namespace SampleApp;

public static class Greeter
{
    public static string Greet(string name) => JsonConvert.SerializeObject(new { message = $"Hello, {name}!" });
}
