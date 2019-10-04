using System.Linq;
using System.IO;
using System.Data.SQLite;

using Cl.Imagicair.Database.EntityFramework;
using Cl.Imagicair.Database.Model;

namespace Db.Utils
{
    public class SqliteHelper
    {
        public static void EjecutarSqliteScript(string archivo)
        {
            string content = File.ReadAllText(archivo);

            string[] statements = content.Split(";");

            using (var sqlConnection = new SQLiteConnection("Data Source=TestDatabase.db;")) // ;FailIfMissing=True
            {
                sqlConnection.Open();

                using (SQLiteCommand command = sqlConnection.CreateCommand())
                {
                    
                    foreach (var statement in statements)
                    {
                        command.CommandText = statement;
                        command.ExecuteNonQuery();
                    }
                }
            }
        }

        public static void CrearDB()
        {
            string dbName = "TestDatabase.db";
            if (File.Exists(dbName))
                File.Delete(dbName);

            using (var dbContext = new PersonaContext())
            {
                dbContext.Database.EnsureCreated();
                if (!dbContext.Personas.Any())
                {
                    dbContext.Personas.AddRange(new Persona[]
                        {
                             new Persona{ Id=1, Name="Persona 1", LastName="Araos" },
                             new Persona{ Id=2, Name="Persona 2", LastName="Araos" },
                             new Persona{ Id=3, Name="Persona 3", LastName="Araos" }
                        });
                    dbContext.SaveChanges();
                }
            }
        }
    }
}