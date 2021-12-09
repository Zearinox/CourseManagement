using CourseManagement.Core.Models;

namespace CourseManagement.Core.Querys
{
    public class CuatrimestreQuery : GenericQuery<Cuatrimestre>
    {
        public string GetSemestreById
        {
            get
            {
                return "SELECT * FROM CUATRIMESTRE WHERE ID = @ID";
            }
        }
        public string GetAllSemesters
        {
            get
            {
                return SelectAllQuery();
            }
        }
    }
}
