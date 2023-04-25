using DesignPatterns.Prototype.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Prototype.Interfaces
{
    public interface IPersona
    {
        IPersona Clonar(); 
        string ObtenerInformacion();
    }
}
