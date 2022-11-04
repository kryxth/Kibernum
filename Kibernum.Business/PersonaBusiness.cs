using Kibernum.Data;
using ProyectoDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kibernum.Business
{
    public class PersonaBusiness
    {
        public void Insertar(PersonaDTO persona)
        {
            PersonaData personaData = new PersonaData();
            personaData.Insertar(persona);
        }

    }
}
