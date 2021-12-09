using CourseManagement.Core.Models;
using CourseManagement.DataAccess;
using System.Collections.Generic;

namespace CourseManagement.Business
{
    public class AniosService
    {
        public static List<Anios> GetAllYears()
        {
            AniosRepository yearRepository = new AniosRepository();
            return yearRepository.GetYears();
        }
        public static Anios GetYearById(int id)
        {
            AniosRepository yearRepository = new AniosRepository();
            return yearRepository.GetYearById(id);
        }
    }
}
