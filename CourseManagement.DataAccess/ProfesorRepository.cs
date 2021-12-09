using CourseManagement.Core;
using CourseManagement.Core.Models;
using CourseManagement.Core.Querys;
using CourseManagement.DataAccess.Conection;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CourseManagement.DataAccess
{
    public class ProfesorRepository
    {
        ProfesorQuery Query = new ProfesorQuery();
        public List<Profesor> GetTeachers()
        {
            var profesores = new List<Profesor>();
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection.ConnectionString))
                using (SqlCommand cmd = new SqlCommand(Query.GetTeachers, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        profesores = Map.ReaderToList<Profesor>(reader);
                    }
                    conn.Close();
                }
                return profesores;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return profesores;
        }
        public Profesor GetTeacherById(int id)
        {
            var teacher = new Profesor();
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection.ConnectionString))
                using (SqlCommand cmd = new SqlCommand(Query.GetTeacherById.Replace("@ID", id.ToString()), conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        teacher = Map.To<Profesor>(reader);
                    }
                    conn.Close();
                }
                return teacher;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return teacher;
        }
        public List<Profesor> GetTeachersByFilter(string filter)
        {
            var profesores = new List<Profesor>();
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection.ConnectionString))
                using (SqlCommand cmd = new SqlCommand(Query.TeacherByFilter.Replace("@Filter", filter), conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        profesores = Map.ReaderToList<Profesor>(reader);
                    }
                    conn.Close();
                }
                return profesores;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return profesores;
        }
        public bool InsertTeacher(Profesor teacher)
        {
            bool result = false;
            try
            {
                string query = ReplaceField(Query.InsertTeacher, teacher);
                using (SqlConnection conn = new SqlConnection(Connection.ConnectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    result = cmd.ExecuteNonQuery() == 1 ? true : false;
                    conn.Close();
                }
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return result;
        }
        public bool UpdateTeacher(Profesor teacher)
        {
            bool result = false;
            string query = ReplaceField(Query.UpdateTeacher, teacher);
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection.ConnectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    result = cmd.ExecuteNonQuery() == 1 ? true : false;
                    conn.Close();
                }
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return result;
        }
        public bool DeleteTeachers(string id)
        {
            bool result = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection.ConnectionString))
                using (SqlCommand cmd = new SqlCommand(Query.DeleteTeacher.Replace("@ID", id), conn))
                {
                    conn.Open();
                    result = cmd.ExecuteNonQuery() == 1 ? true : false;
                    conn.Close();
                }
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return result;
        }
        private string ReplaceField(string query, Profesor teacher)
        {
            query = query.Replace("@Id", teacher.Id.ToString());
            query = query.Replace("@Nombre", "'" + teacher.Nombre + "'");
            query = query.Replace("@Apellido", "'" + teacher.Apellido + "'");
            return query;
        }
    }
}
