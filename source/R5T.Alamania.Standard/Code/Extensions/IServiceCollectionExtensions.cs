using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Bulgaria.UserProfileDirectory;
using R5T.Costobocia.Standard;
using R5T.Dacia;

using R5T.Alamania.Bulgaria;


namespace R5T.Alamania.Standard
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="IRivetOrganizationDirectoryPathProvider"/> service.
        /// </summary>
        public static IServiceCollection AddRivetOrganizationDirectoryPathProvider(this IServiceCollection services)
        {
            services.AddRivetOrganizationDirectoryPathProvider(
                services.AddDropboxDirectoryPathProviderAction(),
                services.AddOrganizationStringlyTypedPathOperatorAction());

            return services;
        }

        /// <summary>
        /// Adds the <see cref="IRivetOrganizationDirectoryPathProvider"/> service.
        /// </summary>
        public static IServiceCollection AddRivetOrganizationDirectoryPathProvider<TRivetOrganizationDirectoryPathProvider>(this IServiceCollection services)
            where TRivetOrganizationDirectoryPathProvider: IRivetOrganizationDirectoryPathProvider
        {
            services.AddRivetOrganizationDirectoryPathProvider();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="IRivetOrganizationDirectoryPathProvider"/> service.
        /// </summary>
        public static ServiceAction<IRivetOrganizationDirectoryPathProvider> AddRivetOrganizationDirectoryPathProviderAction(this IServiceCollection services)
        {
            var serviceAction = new ServiceAction<IRivetOrganizationDirectoryPathProvider>(() => services.AddRivetOrganizationDirectoryPathProvider());
            return serviceAction;
        }
    }
}
