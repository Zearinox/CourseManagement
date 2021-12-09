using CourseManagement.Core;
using CourseManagement.Core.Models;
using CourseManagement.Core.Querys;
using CourseManagement.DataAccess.Conection;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CourseManagement.DataAccess
{
    public class AniosRepository
    {
        AniosQuery Query = new AniosQuery();
        public List<Anios> GetYears()
        {
            var years = new List<Anios>();
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection.ConnectionString))
                using (SqlCommand cmd = new SqlCommand(Query.GetAllYears, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        years = Map.ReaderToList<Anios>(reader);
                    }
                    conn.Close();
                }
                return years;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return years;
        }
        public Anios GetYearById(int id)
        {
            var year = new Anios();
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection.ConnectionString))
                using (SqlCommand cmd = new SqlCommand(Query.GetYearById.Replace("@ID", id.ToString()), conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        year = Map.To<Anios>(reader);
                    }
                    conn.Close();
                }
                return year;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return year;
        }
    }
}
