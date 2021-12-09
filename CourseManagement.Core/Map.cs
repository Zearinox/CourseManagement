using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;

namespace CourseManagement.Core
{
    public static class Map
    {
        private static List<string> PropsExcents = new List<string>()
        {
            "Cuatrimestre", "Anios", "Profesor"
        };
        /// <summary>
        ///     Convierte un DataReader en una lista de algún objeto genérico
        /// </summary>
        /// <returns> Lisa Genérico </returns>
        public static List<T> ReaderToList<T>(IDataReader dr)
        {
            List<T> list = new List<T>();
            T obj = default(T);
            while (dr.Read())
            {
                obj = Activator.CreateInstance<T>();
                foreach (PropertyInfo prop in obj.GetType().GetProperties())
                {
                    if (!PropsExcents.Contains(prop.Name))
                    {
                        if (!object.Equals(dr[prop.Name], DBNull.Value))
                        {
                            prop.SetValue(obj, dr[prop.Name], null);
                        }
                    }
                }
                list.Add(obj);
            }
            return list;
        }

        /// <summary>
        ///     Convierte un DataReader en un objeto genérico
        /// </summary>
        /// <returns> Objeto Genérico </returns>
        public static T To<T>(IDataReader dr)
        {
            List<T> list = new List<T>();
            T obj = default(T);
            while (dr.Read())
            {
                obj = Activator.CreateInstance<T>();
                foreach (PropertyInfo prop in obj.GetType().GetProperties())
                {
                    if (!PropsExcents.Contains(prop.Name))
                    {
                        if (!object.Equals(dr[prop.Name], DBNull.Value))
                        {
                            prop.SetValue(obj, dr[prop.Name], null);
                        }
                    }
                }
                list.Add(obj);
            }
            return list.FirstOrDefault();
        }
    }
}
