using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Entities._02_Task
{
    public abstract class ReportFactory
    {
        protected abstract IReport CreateReport();
        public void Generate() 
        {
            var report = this.CreateReport();
            report.Generate();
        }
    }
}
