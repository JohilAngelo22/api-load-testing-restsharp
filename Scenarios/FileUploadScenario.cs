using NBomber.Contracts;
using NBomber.CSharp;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_load_testing_restsharp.Scenarios;

internal class FileUploadScenario
{
    public static ScenarioProps Create()
    {
        return Scenario.Create("file_upload_test", async context =>
        {
            var client = new RestClient("https://echo.free.beeceptor.com");
            var request = new RestRequest("/upload", Method.Post);
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "Data", "test.jpg");

            if (!File.Exists(filePath))
            {
                Console.WriteLine($"File not found at path: {filePath}");
            }

            request.AddFile("file", filePath);

            var response = await client.ExecuteAsync(request);

            return response.IsSuccessful
                ? Response.Ok()
                : Response.Fail();
        })
            .WithLoadSimulations(
            Simulation.Inject(rate: 20, interval: TimeSpan.FromSeconds(1), during: TimeSpan.FromSeconds(30)));

    }
}