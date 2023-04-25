using DesignPatternsDomain.Entities;
using DesignPatternsDomain.ResultNotificationResult;

namespace DesignPatternsDomain.Notifications
{
    public class PersonaValidationNotification
    {
        public List<string> Errors { get; private set; }

        public PersonaValidationNotification()
        {
            Errors = new List<string>();
        }

        public void AddError(string error)
        {
            Errors.Add(error);
        }

        public ResultNotification Validate(Persona persona)
        {
            var result = new ResultNotification();

            if (string.IsNullOrEmpty(persona.Nombre))
            {
                AddError("El nombre es requerido");
            }

            if (persona.Edad < 18)
            {
                AddError("La edad debe ser mayor a 18");
            }

            if (string.IsNullOrEmpty(persona.Email))
            {
                AddError("El email es requerido");
            }
            else if (!IsValidEmail(persona.Email))
            {
                AddError("El email es inválido");
            }

            if (string.IsNullOrEmpty(persona.Direccion))
            {
                AddError("La dirección es requerida");
            }

            if (Errors.Count > 0)
            {
                result.Failure(Errors);
            }
            else
            {
                result.Success();
            }

            return result;
        }

        private bool IsValidEmail(string email)
        {
            if (!email.Contains("@"))
                return false;
            return true;
        }
    }
}
