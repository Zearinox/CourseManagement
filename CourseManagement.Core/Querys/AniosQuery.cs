using CourseManagement.Core.Models;

namespace CourseManagement.Core.Querys
{
    public class AniosQuery : GenericQuery<Anios>
    {
        public string GetYearById
        {
            get
            {
                return "SELECT * FROM ANIOS WHERE ID = @ID";
            }
        }
        public string GetAllYears
        {
            get
            {
                return SelectAllQuery();
            }
        }
    }
}
