using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;

namespace CourseManagement.DataAccess.Conection
{
    public class Connection
    {
        public static string ConnectionString = @"Data Source=PC-ZEARINOX-JP\SQLEXPRESS;Initial Catalog=Materia;Integrated Security=True";
        //public static string cn = "data source=DESKTOP-1J74J22; initial catalog=ProgMaterias;user id=sistemas;password=sistemas";
    }
}
