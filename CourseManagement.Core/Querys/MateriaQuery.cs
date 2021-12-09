using CourseManagement.Core.Models;

namespace CourseManagement.Core.Querys
{
    public class MateriaQuery : GenericQuery<Materia>
    {
        public string GetSubjectById
        {
            get
            {
                return "SELECT * FROM MATERIA WHERE ID = @ID";
            }
        }
        public string GetSubjects
        {
            get
            {
                return SelectAllQuery();
            }
        }
        public string InsertSubject
        {
            get
            {
                return InsertQuery();
            }
        }
        public string UpdateSubject
        {
            get
            {
                return UpdateQuery();
            }
        }
        public string DeleteSubject
        {
            get
            {
                return DeleteQuery();
            }
        }
        // TODO: Modificar
        public string SubjectByFilter
        {
            get
            {
                return "SELECT* FROM PROFESOR WHERE NOMBRE COLLATE SQL_Latin1_General_CP1_CI_AS LIKE '%@Filter%' OR Apellido COLLATE SQL_Latin1_General_CP1_CI_AS LIKE '%@Filter%'";
            }
        }
    }
}
