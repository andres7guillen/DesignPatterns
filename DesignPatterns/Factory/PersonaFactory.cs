using CSharpFunctionalExtensions;
using DesignPatternsDomain.Entities;
using DesignPatternsDomain.Notifications;
using DesignPatternsDomain.Specifications.Implementations;
using DesignPatternsDomain.Specifications.Interfaces;


namespace DesignPatterns.Factory
{
    public class PersonaFactory
    {
        ISpecification<Persona> _specification;

        public PersonaFactory(ISpecification<Persona> specification)
        {
            _specification = specification;
            //_personaValidationNotification = new PersonaValidationNotification();
        }
        public static Result<DesignPatternsDomain.Entities.Persona> CrearPersona(string nombre, int edad, string direccion, string telefono, string email)
        {
            DesignPatternsDomain.Entities.Persona persona = new DesignPatternsDomain.Entities.Persona(nombre: nombre, edad: edad, direccion: direccion, telefono: telefono, email: email);
            PersonaValidationNotification personaValidationNotification = new PersonaValidationNotification();

            //var validadEdad = new MayorDeEdadSpecification().IsSatisfiedBy(persona);
            //var validarPropiedades = new PropiedadesNoNullSpecification().IsSatisfiedBy(persona);
            //if (validarPropiedades.IsFailure)
            //{
            //    return Result.Failure<Persona>(validarPropiedades.Error);
            //}
            //if (validadEdad.IsFailure)
            //{
            //    return Result.Failure<Persona>(validadEdad.Error);
            //}
            var personaValidation = personaValidationNotification.Validate(persona);
            if (!personaValidation.IsSuccess)
            {
                return Result.Failure<DesignPatternsDomain.Entities.Persona>(string.Concat(personaValidation.Errors, "-"));
            }
            return Result.Success(persona);
        }
    }
}
