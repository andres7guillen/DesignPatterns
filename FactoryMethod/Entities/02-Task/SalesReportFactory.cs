using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Entities._02_Task
{
    public class SalesReportFactory : ReportFactory
    {
        protected override IReport CreateReport()
        {
            return new SalesReport();
        }
    }
}
