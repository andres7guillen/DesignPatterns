using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDomain.Entities.Prototype
{
    /// <summary>
    /// Prototype Superficial => solo para clonar tipos primitivos.
    /// </summary>
    public class UsuarioSuperficial : ICloneable
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Photo ProfilePhoto { get; set; }


        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public override string ToString()
        {
            return $"Nombre: {Nombre}\n Apellido: {Apellido} \n Photo: {ProfilePhoto.Descripcion}";
        }
    }


    /// <summary>
    /// Prototype deep => profundo para clonar tambien referencias a otras clases.
    /// </summary>
    public class UsuarioProfundo : ICloneable
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Photo ProfilePhoto { get; set; }
        public object Clone()
        {
            UsuarioProfundo clonado = this.MemberwiseClone() as UsuarioProfundo;
            Photo photo = new Photo();
            photo.Url = this.ProfilePhoto.Url;
            photo.Descripcion = this.ProfilePhoto.Descripcion;
            clonado.ProfilePhoto = photo;
            return clonado;
        }

        public override string ToString()
        {
            return $"Nombre: {Nombre}\n Apellido: {Apellido} \n Photo: {ProfilePhoto.Descripcion}";
        }

    }

    public class Photo 
    {
        public string Descripcion { get; set; }
        public string Url { get; set; }
    }
}
