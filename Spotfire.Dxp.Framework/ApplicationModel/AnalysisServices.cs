using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotfire.Dxp.Framework.ApplicationModel
{
    public static class AnalysisServices
    {
        private static IServiceProvider serviceProvider;

        public static T GetService<T>() where T : class
        {
            return (T)((object)AnalysisServices.GetService(typeof(T)));
        }

        public static object GetService(System.Type serviceType)
        {
            return AnalysisServices.serviceProvider.GetService(serviceType);
        }
    }
}
