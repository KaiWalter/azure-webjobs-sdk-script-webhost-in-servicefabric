#r "Microsoft.ServiceBus"

using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.ServiceBus.Messaging;

public static IActionResult Run(string req,out BrokeredMessage outMessage, TraceWriter log)
{
    outMessage = new BrokeredMessage(req);
    return new StatusCodeResult(StatusCodes.Status202Accepted);
}
