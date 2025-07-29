// See https://aka.ms/new-console-template for more information
using api_load_testing_restsharp.Scenarios;
using NBomber.Contracts.Stats;
using NBomber.CSharp;



NBomberRunner
    .RegisterScenarios([ GetLoadScenarios.Create(), SpikeLoadScenario.Create(), FileUploadScenario.Create()])
    .WithReportFileName("restsharp_report")
    .WithReportFolder("./reports")
    .WithReportFormats(ReportFormat.Html)
    .Run();
Console.WriteLine("Load Testing completed");
