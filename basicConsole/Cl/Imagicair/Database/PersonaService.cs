using System.Linq;
using System.Collections.Generic;

using Cl.Imagicair.Database.EntityFramework;
using Cl.Imagicair.Database.Model;

namespace Cl.Imagicair.Database
{
    public class PersonaService
    {
        public long CrearPersona(Persona persona)
        {
            using (var context = new PersonaContext())
            {
                context.Personas.Add(persona);
                context.SaveChanges();

                return persona.Id;
            }
        }

        public List<Persona> TraerTodas()
        {
            using (var context = new PersonaContext())
            {
                return context.Personas.ToList();
            }
        }

    }
}