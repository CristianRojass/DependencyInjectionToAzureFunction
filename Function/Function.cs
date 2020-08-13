using Dependencies.Interfaces;
using Azure_Function.ServiceLocator;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace Azure_Function.Function {
    
    public class Function {

        private readonly IServiceLocator _services;

        public Function(IServiceLocator services) {
            _services = services;
        }

        [FunctionName("Animal")]
        public void Run([TimerTrigger("*/3 * * * * *")]TimerInfo myTimer, ILogger log) {
            log.LogInformation($"ServiceLocator -   Animal: {_services.GetService<IAnimal>().GetSpecie()}");
        }

    }

}