using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDomain.Interfaces.Builder
{
    public interface IBuilder<T>
    {
        public T build();
    }
}
