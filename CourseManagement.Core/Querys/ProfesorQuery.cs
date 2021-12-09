using CourseManagement.Core.Models;

namespace CourseManagement.Core.Querys
{
    public class ProfesorQuery : GenericQuery<Profesor>
    {
        public string GetTeacherById
        {
            get
            {
                return "SELECT * FROM PROFESOR WHERE ID = @ID";
            }
        }
        public string GetTeachers
        {
            get
            {
                return SelectAllQuery();
            }
        }
        public string InsertTeacher
        {
            get
            {
                return InsertQuery();
            }
        }
        public string UpdateTeacher
        {
            get
            {
                return UpdateQuery();
            }
        }
        public string DeleteTeacher
        {
            get
            {
                return DeleteQuery();
            }
        }
        public string TeacherByFilter
        {
            get
            {
                return "SELECT* FROM PROFESOR WHERE NOMBRE COLLATE SQL_Latin1_General_CP1_CI_AS LIKE '%@Filter%' OR Apellido COLLATE SQL_Latin1_General_CP1_CI_AS LIKE '%@Filter%'";
            }
        }
    }
}
