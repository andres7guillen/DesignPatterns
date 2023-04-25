using CSharpFunctionalExtensions;
using DesignPatternsDomain.Entities;
using DesignPatternsDomain.Specifications.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDomain.Specifications.Implementations
{
    public class PropiedadesNoNullSpecification : ISpecification<Persona>
    {
        public Result IsSatisfiedBy(Persona persona)
        {
            var properties = typeof(Persona).GetProperties();
            foreach (var property in properties) 
            {
                if (property.GetValue(persona) == null) 
                {
                    return Result.Failure($"La propiedad {property.Name} no puede ser null");
                }
            }

            return Result.Success();

            
        }
    }
}
