using System;
using RateIt.Core.Companies;
using RateIt.Core.Reporting;
using RateIt.Entities.Ioc;

namespace RateIt.Core.Ioc
{
    public class CoreRegistry : StructureMap.Registry
    {
        public CoreRegistry()
        {
           ForSingletonOf<ICompanyService>().Use<CompanyService>();
           ForSingletonOf<INPSReportingService>().Use<NPSReportingService>();

			IncludeRegistry<DatabaseRegistry>();
        }

	    public static void OnConfigure(IServiceProvider serviceProvider)
	    {
		    DatabaseRegistry.OnConfigure(serviceProvider);
	    }
    }
}
