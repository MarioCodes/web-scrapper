using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using webscrapper.Model;
using webscrapper.Service;

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
        public async Task Run([TimerTrigger("0 0 20 * * *"
#if DEBUG
            , RunOnStartup = true
#endif
            )] TimerInfo timerInfo, FunctionContext context)
        {
            _logger.LogInformation("C# timer trigger function executed!");

            var products = new List<Product>();
            products.Add(await Scraper.GetProduct("https://www.pccomponentes.com/hp-victus-16-s0011ns-amd-ryzen-7-7840hs-32gb-1tb-ssd-rtx-4060-161"));

            products.ForEach(p => Console.WriteLine($"scrapped product '{p.Url}', available '{p.IsAvailable}'"));
        }
    }
}
