using CourseManagement.Core.Models;
using CourseManagement.DataAccess;
using System.Collections.Generic;

namespace CourseManagement.Business
{
    public static class ProfesorService
    {
        public static List<Profesor> GetAllTeachs()
        {
            ProfesorRepository profesorRepository = new ProfesorRepository();
            return profesorRepository.GetTeachers();
        }
        public static List<Profesor> GetTeachersByFilter(string filter)
        {
            ProfesorRepository profesorRepository = new ProfesorRepository();
            return profesorRepository.GetTeachersByFilter(filter);
        }
        public static Profesor GetTeacherById(int id)
        {
            ProfesorRepository profesorRepository = new ProfesorRepository();
            return profesorRepository.GetTeacherById(id);
        }
        public static bool InsertTeacher(Profesor teacher)
        {
            ProfesorRepository profesorRepository = new ProfesorRepository();
            return profesorRepository.InsertTeacher(teacher);
        }
        public static bool UpdateTeacher(Profesor teacher)
        {
            ProfesorRepository profesorRepository = new ProfesorRepository();
            return profesorRepository.UpdateTeacher(teacher);
        }
        public static bool DeleteTeacher(string id)
        {
            ProfesorRepository profesorRepository = new ProfesorRepository();
            return profesorRepository.DeleteTeachers(id);
        }
    }
}
