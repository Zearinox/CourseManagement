using CourseManagement.Core.Models;
using CourseManagement.DataAccess;
using System.Collections.Generic;

namespace CourseManagement.Business
{
    public class CuatrimestreService
    {
        public static List<Cuatrimestre> GetAllSemestres()
        {
            CuatrimestreRepository cuatriRepository = new CuatrimestreRepository();
            return cuatriRepository.GetSemestres();
        }
        public static Cuatrimestre GetSemestreById(int id)
        {
            CuatrimestreRepository cuatriRepository = new CuatrimestreRepository();
            return cuatriRepository.GetSemestreById(id);
        }
    }
}
