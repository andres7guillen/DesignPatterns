using CSharpFunctionalExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDomain.Specifications.Interfaces
{
    public interface ISpecification<T>
    {
        public Result IsSatisfiedBy(T entity);
    }
}
