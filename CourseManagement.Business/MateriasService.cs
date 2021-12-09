using CourseManagement.Core.Models;
using CourseManagement.DataAccess;
using System.Collections.Generic;

namespace CourseManagement.Business
{
    public class MateriasService
    {
        public static List<Materia> GetAllSubjets()
        {
            MateriaRepository matRepository = new MateriaRepository();
            return matRepository.GetSubjets();
        }
        public static List<Materia> GetSubjetsByFilter(string filter)
        {
            MateriaRepository matRepository = new MateriaRepository();
            return matRepository.GetSubjetsByFilter(filter);
        }
        public static Materia GetTeacherById(int id)
        {
            MateriaRepository matRepository = new MateriaRepository();
            return matRepository.GetSubjetsById(id);
        }
        public static bool InsertSubjet(Materia subjetc)
        {
            MateriaRepository matRepository = new MateriaRepository();
            return matRepository.InsertSubjet(subjetc);
        }
        public static bool UpdateSubjet(Materia subjetc)
        {
            MateriaRepository matRepository = new MateriaRepository();
            return matRepository.UpdateSubjet(subjetc);
        }
        public static bool DeleteSubjet(string id)
        {
            MateriaRepository matRepository = new MateriaRepository();
            return matRepository.DeleteSubjetcs(id);
        }
    }
}
