using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Bank
{
    public class ControladorPersona
    {
        private List<Persona> listadoPersona;
        public ControladorPersona()
        {
            listadoPersona = new List<Persona>();
        }
        public void adicionarPersona(Persona persona)
        {
            listadoPersona.Add(persona);
        }
    }

    
}
