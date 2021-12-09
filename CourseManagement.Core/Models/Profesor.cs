using System.ComponentModel;

namespace CourseManagement.Core.Models
{
    public class Profesor
    {
        //[Description("key")]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
    }
}
