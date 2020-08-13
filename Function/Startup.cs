using Azure_Function.Function;
using Azure_Function.ServiceLocator;
using Dependencies.Environments;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

[assembly: FunctionsStartup(typeof(Startup))]
namespace Azure_Function.Function {

    public class Startup : FunctionsStartup {
        public override void Configure(IFunctionsHostBuilder builder) {

            //Contenedor de dependencias para Producción
            builder.Services.AddSingleton<IServiceLocator, Production>();

            //Contenedor de dependencias para Desarrollo
            //builder.Services.AddSingleton<IServiceLocator, Development>();

        }

    }

}