using System.Net;
using Microsoft.AspNetCore.Mvc;

public static IActionResult Run(string req,TraceWriter log)
{
    return new OkObjectResult(new Test { Name = "Hello from a Function hosted in .NET Core 2 WebHost in Service Fabric" });
}

public class Test
{
    public string Name { get; set; }
}