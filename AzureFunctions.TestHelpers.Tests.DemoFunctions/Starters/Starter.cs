using System.Threading.Tasks;
using AzureFunctions.TestHelpers.Orchestrators;
using Microsoft.Azure.WebJobs;

namespace AzureFunctions.TestHelpers.Starters
{
    public static class Starter
    {
        [FunctionName(nameof(Starter))]
        public static async Task Run([TimerTrigger("0 0 1 * * *")]
            TimerInfo timerInfo,
            [OrchestrationClient] DurableOrchestrationClientBase orchestrationClient)
        {
            await orchestrationClient.StartNewAsync(nameof(Orchestration), null);
        }
    }
}