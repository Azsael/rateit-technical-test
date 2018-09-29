using System;
using System.Runtime.CompilerServices;
using RateIt.Common.Ioc;
using RateIt.Core.Companies;
using RateIt.Core.Reporting;
using RateIt.Entities.Ioc;
[assembly: InternalsVisibleTo("RateIt.Core.Tests")]

namespace RateIt.Core.Ioc
{
    public class CoreRegistry : StructureMap.Registry
    {
        public CoreRegistry()
        {
			ForSingletonOf<ICompanyService>().Use<CompanyService>();
			ForSingletonOf<INPSReportingService>().Use<NPSReportingService>();

			IncludeRegistry<CommonRegistry>();
			IncludeRegistry<DatabaseRegistry>();
        }

	    public static void OnConfigure(IServiceProvider serviceProvider)
	    {
		    DatabaseRegistry.OnConfigure(serviceProvider);
	    }
    }
}
