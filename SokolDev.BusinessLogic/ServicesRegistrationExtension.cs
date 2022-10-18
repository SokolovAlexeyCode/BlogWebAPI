using Microsoft.Extensions.DependencyInjection;
using NetCore.AutoRegisterDi;

namespace SokolDev.BusinessLogic;

public static class ServicesRegistrationExtension
{
    public static void AddBusinessLogicServices(this IServiceCollection services)
    {
        services.RegisterAssemblyPublicNonGenericClasses()
            .Where(c => c.Name.EndsWith("Service"))
            .AsPublicImplementedInterfaces();
    }
}