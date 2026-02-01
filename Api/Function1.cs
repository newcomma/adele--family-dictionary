using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using Shared;

namespace Api;

public class Function1
{
    private readonly ILogger<Function1> _logger;

    public Function1(ILogger<Function1> logger)
    {
        _logger = logger;
    }

    [Function("Function1")]
    public IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequest req)
    {
        _logger.LogInformation("C# HTTP trigger function processed a request.");
        return new OkObjectResult("Welcome to Azure Functions!");
    }


    [Function("GetAll")]
    public IActionResult GetAll([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequest req)
    {
        List<Definition> definitions =
            [
                new Definition { Id = 1, Name = "Farfanugan", Description = "A word of complete distress" },
                new Definition { Id = 2, Name = "Sockies", Description = "A synonym for socks" },
            ];
        return new OkObjectResult("Welcome to Azure Functions!");
    }

    
}