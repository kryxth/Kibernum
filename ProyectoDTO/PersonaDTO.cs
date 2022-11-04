using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDTO
{
    public class PersonaDTO
    {
        public int IdPersona { get; set; }
        public string Documento { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string NumerosTelefonicos { get; set; }
        public string CorreosElectronicos { get; set; }
        public string DirecionesFisicas { get; set; }
    }
}
