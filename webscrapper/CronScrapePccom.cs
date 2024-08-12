using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace webscrapper
{
    public class CronScrapePccom
    {
        private readonly ILogger _logger;

        public CronScrapePccom(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<CronScrapePccom>();
        }

        [Function("CronScrapePccom")]
        [FixedDelayRetry(3, "00:01:00")]
        // once every day at 8PM
        public void Run([TimerTrigger("0 0 20 * * *"
#if DEBUG
            , RunOnStartup = true
#endif
            )] TimerInfo timerInfo, FunctionContext context)
        {
            _logger.LogInformation("C# timer trigger function executed!");
        }
    }
}
