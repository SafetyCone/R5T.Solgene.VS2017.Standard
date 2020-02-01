using System;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

using R5T.Bedford.Bath.Standard;
using R5T.Chalandri.DropboxRivetTestingData;
using R5T.Evosmos.CDriveTemp;
using R5T.Richmond;
using R5T.Solutas.Standard;


namespace R5T.Solgene.VS2017.Standard.Construction
{
    class Startup : StartupBase
    {
        public Startup(ILogger<Startup> logger)
            : base(logger)
        {
        }

        protected override void ConfigureServicesBody(IServiceCollection services)
        {
            services
                .AddSingleton<Program>()
                .AddVisualStudioSolutionFileGenerator()
                .AddTemporaryDirectoryFilePathProvider()
                .AddTestingDataDirectoryContentPathsProvider()
                .AddVisualStudioSolutionFileSerializer()
                .AddTextFileEqualityComparer()
                ;
        }
    }
}
