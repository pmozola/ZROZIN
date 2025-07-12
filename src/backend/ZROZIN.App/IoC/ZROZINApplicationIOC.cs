using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using ZROZIN.App.Handlers.Behaviors;

namespace ZROZIN.App.IoC;

public static class ApplicationIoCExtension
{
    public static IServiceCollection AddZROZINServices(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddValidatorsFromAssembly(typeof(ApplicationIoCExtension).Assembly);
        serviceCollection.AddMediatR(config =>
        {
            config.RegisterServicesFromAssembly(typeof(ApplicationIoCExtension).Assembly);
            config.AddOpenBehavior(typeof(ValidationBehavior<,>));
        });


        return serviceCollection;
    }
}