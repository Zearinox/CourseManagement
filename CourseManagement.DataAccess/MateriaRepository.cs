using CourseManagement.Core;
using CourseManagement.Core.Models;
using CourseManagement.Core.Querys;
using CourseManagement.DataAccess.Conection;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CourseManagement.DataAccess
{
    public class MateriaRepository
    {
        MateriaQuery Query = new MateriaQuery();
        public List<Materia> GetSubjets()
        {
            ProfesorRepository teachRepo = new ProfesorRepository();
            AniosRepository anioRepo = new AniosRepository();
            CuatrimestreRepository semestreRepo = new CuatrimestreRepository();
            var subjects = new List<Materia>();
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection.ConnectionString))
                using (SqlCommand cmd = new SqlCommand(Query.GetSubjects, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        subjects = Map.ReaderToList<Materia>(reader);
                        foreach(var subject in subjects)
                        {
                            subject.Profesor = teachRepo.GetTeacherById(subject.IdProfesor.Value);
                            subject.Anios = anioRepo.GetYearById(subject.IdAnio.Value);
                            subject.Cuatrimestre = semestreRepo.GetSemestreById(subject.IdCuatrimestre.Value);
                        }
                    }
                    conn.Close();
                }
                return subjects;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return subjects;
        }

        public Materia GetSubjetsById(int id)
        {
            ProfesorRepository teachRepo = new ProfesorRepository();
            AniosRepository anioRepo = new AniosRepository();
            CuatrimestreRepository semestreRepo = new CuatrimestreRepository();
            var subject = new Materia();
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection.ConnectionString))
                using (SqlCommand cmd = new SqlCommand(Query.GetSubjectById.Replace("@ID", id.ToString()), conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        subject = Map.To<Materia>(reader);
                        subject.Profesor = teachRepo.GetTeacherById(subject.IdProfesor.Value);
                        subject.Anios = anioRepo.GetYearById(subject.IdAnio.Value);
                        subject.Cuatrimestre = semestreRepo.GetSemestreById(subject.IdCuatrimestre.Value);
                    }
                    conn.Close();
                }
                return subject;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return subject;
        }
        public List<Materia> GetSubjetsByFilter(string filter)
        {
            var subjects = new List<Materia>();
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection.ConnectionString))
                using (SqlCommand cmd = new SqlCommand(Query.SubjectByFilter.Replace("@Filter", filter), conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        subjects = Map.ReaderToList<Materia>(reader);
                    }
                    conn.Close();
                }
                return subjects;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return subjects;
        }
        public bool InsertSubjet(Materia subjet)
        {
            bool result = false;
            try
            {
                string query = ReplaceField(Query.InsertSubject, subjet);
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
        public bool UpdateSubjet(Materia subjet)
        {
            bool result = false;
            string query = ReplaceField(Query.UpdateSubject, subjet);
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
        public bool DeleteSubjetcs(string id)
        {
            bool result = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection.ConnectionString))
                using (SqlCommand cmd = new SqlCommand(Query.DeleteSubject.Replace("@ID", id), conn))
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
        private string ReplaceField(string query, Materia subjetc)
        {
            query = query.Replace("@NombreMateria", "'" + subjetc.NombreMateria + "'");
            query = query.Replace("@DiaCursada", "'" + subjetc.DiaCursada + "'");
            query = query.Replace("@Cursada", subjetc.Cursada.Value ? "1" : "0");
            query = query.Replace("@Aprobada", subjetc.Aprobada.Value ? "1" : "0");
            query = query.Replace("@IdAnio", subjetc.IdAnio.ToString());
            query = query.Replace("@IdCuatrimestre", subjetc.IdCuatrimestre.ToString());
            query = query.Replace("@IdProfesor", subjetc.IdProfesor.ToString());
            query = query.Replace("@Id", subjetc.Id.ToString());
            return query;
        }
    }
}
