using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace ConsoleApplication1
{
    [ServiceContract]
    public interface ICalc
    {
        [OperationContract]
        double Add(double a, double b);
    }
}
