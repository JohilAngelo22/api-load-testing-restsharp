using NBomber.Contracts;
using NBomber.CSharp;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_load_testing_restsharp.Scenarios;

internal class SpikeLoadScenario
{
    public static ScenarioProps Create()
    {

        return Scenario.Create("spike_load_users", async context =>
        {
            var client = new RestClient("https://jsonplaceholder.typicode.com");
            var request = new RestRequest("/users", Method.Get);

            var response = await client.ExecuteAsync(request);

            return response.IsSuccessful
                ? Response.Ok(statusCode: response.StatusCode.ToString())
                : Response.Fail(statusCode: response.StatusCode.ToString());
        })
    .WithLoadSimulations([
        
                Simulation.Inject(rate: 50, interval: TimeSpan.FromSeconds(1), during: TimeSpan.FromSeconds(10)),
                Simulation.Inject(rate: 500, interval: TimeSpan.FromSeconds(1), during: TimeSpan.FromSeconds(10)),
                Simulation.Inject(rate: 1000, interval: TimeSpan.FromSeconds(1), during: TimeSpan.FromSeconds(10))]
          );
    }
}
