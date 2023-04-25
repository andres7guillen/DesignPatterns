using CSharpFunctionalExtensions;
using DesignPatternsDomain.Entities;
using DesignPatternsDomain.Specifications.Interfaces;

namespace DesignPatternsDomain.Specifications.Implementations
{
    public class MayorDeEdadSpecification : ISpecification<Persona>
    {
        public Result IsSatisfiedBy(Persona persona)
        {
            if (persona.Edad < 18) 
            {
                return Result.Failure("La persona debe ser mayor de edad");
            }
            return Result.Success();
        }
    }
}
