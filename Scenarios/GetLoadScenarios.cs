using NBomber.Contracts;
using NBomber.CSharp;
using RestSharp;

namespace api_load_testing_restsharp.Scenarios;

internal class GetLoadScenarios
{
    public static ScenarioProps Create()
    {
        return Scenario.Create("restsharp_get_users", async context =>
        {
            var client = new RestClient("https://jsonplaceholder.typicode.com");
            var request = new RestRequest("/users", Method.Get);

            var response = await client.ExecuteAsync(request);

            return response.IsSuccessful
                ? Response.Ok(statusCode: response.StatusCode.ToString())
                : Response.Fail(statusCode: response.StatusCode.ToString());
        })
    .WithLoadSimulations(
            Simulation.Inject(rate: 100,
                              interval: TimeSpan.FromSeconds(1),
                              during: TimeSpan.FromMinutes(1)));
      
    }
}