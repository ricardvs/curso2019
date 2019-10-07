using NUnit.Framework;
using Db.Utils;

using Cl.Imagicair.Database.Model;

namespace Cl.Imagicair.Database.personaService
{
    [TestFixture]
    public class CrearPersona
    {
        [OneTimeSetUp]
        public void CrearDB()
        {
            SqliteHelper.EjecutarSqliteScript("../../../scripts/carga_inicial.sql");
        }

        [TearDown]
        public void Reset()
        {
            SqliteHelper.EjecutarSqliteScript("../../../scripts/persona/teardown_01.sql");
        }

        [Test]
        public void CasoNormal()
        {
            var service = new PersonaService ();

            long id = service.CrearPersona(new Persona {Name = "Potmos", LastName = "Aeternis"});

            Assert.That(id, Is.Not.Null);
            Assert.That(id, Is.GreaterThan(50));
        }
    }
}