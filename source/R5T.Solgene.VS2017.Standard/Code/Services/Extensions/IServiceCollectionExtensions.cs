using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;


namespace R5T.Solgene.VS2017.Standard
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="IVisualStudioSolutionFileGenerator"/> service.
        /// </summary>
        public static IServiceCollection AddVisualStudioSolutionFileGenerator(this IServiceCollection services)
        {
            services.AddVS2017VisualStudioSolutionFileGenerator();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="IVisualStudioSolutionFileGenerator"/> service.
        /// </summary>
        public static ServiceAction<IVisualStudioSolutionFileGenerator> AddVisualStudioSolutionFileGeneratorAction(this IServiceCollection services)
        {
            var serviceAction = new ServiceAction<IVisualStudioSolutionFileGenerator>(() => services.AddVisualStudioSolutionFileGenerator());
            return serviceAction;
        }
    }
}
