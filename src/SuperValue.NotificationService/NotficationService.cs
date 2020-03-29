using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace Company.Function
{
    public static class NotficationService
    {
        [FunctionName("NotficationService")]
        public static void Run([ServiceBusTrigger("OrderReceivedQueue", "OrderReceivedSubscription", Connection = "AzureWebJobsStorage")]string mySbMsg, ILogger log)
        {
            log.LogInformation($"C# ServiceBus topic trigger function processed message: {mySbMsg}");
        }
    }
}
