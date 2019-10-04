using System.ComponentModel.DataAnnotations.Schema;

namespace Cl.Imagicair.Database.Model
{
    [Table("PERSONA")]
    public class Persona
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
    }
}