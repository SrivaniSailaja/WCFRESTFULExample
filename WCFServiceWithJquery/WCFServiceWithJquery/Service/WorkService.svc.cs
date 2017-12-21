using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Text;

namespace WCFServiceWithJQuery.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WorkService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select WorkService.svc or WorkService.svc.cs at the Solution Explorer and start debugging.
    [AspNetCompatibilityRequirements(RequirementsMode =AspNetCompatibilityRequirementsMode.Allowed)]
    public class WorkService : IWorkService
    {
        public string DoWork()
        {
            return "Hello from DoWork";
        }

        public int DoSquare(int value)
        {
            return value * value;
        }


        public int Add(AddValue values)
        {
            return (values.value1 + values.value2);
        }
    }
}
