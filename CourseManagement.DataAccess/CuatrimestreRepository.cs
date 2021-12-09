using CourseManagement.Core;
using CourseManagement.Core.Models;
using CourseManagement.Core.Querys;
using CourseManagement.DataAccess.Conection;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CourseManagement.DataAccess
{
    public class CuatrimestreRepository
    {
        CuatrimestreQuery Query = new CuatrimestreQuery();
        public List<Cuatrimestre> GetSemestres()
        {
            var cuatrimestres = new List<Cuatrimestre>();
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection.ConnectionString))
                using (SqlCommand cmd = new SqlCommand(Query.GetAllSemesters, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        cuatrimestres = Map.ReaderToList<Cuatrimestre>(reader);
                    }
                    conn.Close();
                }
                return cuatrimestres;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return cuatrimestres;
        }
        public Cuatrimestre GetSemestreById(int id)
        {
            var semestre = new Cuatrimestre();
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection.ConnectionString))
                using (SqlCommand cmd = new SqlCommand(Query.GetSemestreById.Replace("@ID", id.ToString()), conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        semestre = Map.To<Cuatrimestre>(reader);
                    }
                    conn.Close();
                }
                return semestre;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return semestre;
        }
    }
}
