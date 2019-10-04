using System.Reflection;
using System.Linq;
using System.Data.Sql;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;

using Cl.Imagicair.Database.Model;

namespace Cl.Imagicair.Database.EntityFramework
{
    public class PersonaContext : DbContext
    {
        DbContextOptionsBuilder contextOptionsBuilder;

        public DbSet<Persona> Personas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            this.contextOptionsBuilder = optionsBuilder;

            optionsBuilder.UseSqlite("Filename=TestDatabase.db", options =>
             {
                 options.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
             });

            base.OnConfiguring(optionsBuilder);
        }

        public Persona BuscarPersona(int id)
        {
            var query = from persona in this.Personas
                        where persona.Id == id
                        select persona;
            return query.FirstOrDefault<Persona>();
        }

        public void BorrarPersona(Persona Persona)
        {
            Personas.Remove(Persona);
            this.SaveChanges();
        }
    }
}