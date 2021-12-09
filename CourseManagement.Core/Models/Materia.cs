using System.ComponentModel;

namespace CourseManagement.Core.Models
{
    public class Materia
    {
        public int Id { get; set; }
        public string NombreMateria { get; set; }
        public string DiaCursada { get; set; }
        public bool? Cursada { get; set; }
        public bool? Aprobada { get; set; }
        public int? IdAnio { get; set; }
        public int? IdCuatrimestre { get; set; }
        public int? IdProfesor { get; set; }

        [Description("NotMapped")]
        public Cuatrimestre Cuatrimestre { get; set; }

        [Description("NotMapped")]
        public Anios Anios { get; set; }

        [Description("NotMapped")]
        public Profesor Profesor { get; set; }

    }
}