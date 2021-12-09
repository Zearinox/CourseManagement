using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;

namespace CourseManagement.Core.Querys
{
    public class GenericQuery<T>
    {
        private IEnumerable<PropertyInfo> GetProperties => typeof(T).GetProperties();
        private string TableName => typeof(T).Name;
        public string SelectAllQuery()
        {
            return $"SELECT * FROM {TableName}";
        }
        public string DeleteQuery()
        {
            return $"DELETE  FROM {TableName} WHERE ID = @ID";
        }
        public string InsertQuery()
        {
            var insertQuery = new StringBuilder($"INSERT INTO {TableName} ");
            insertQuery.Append("(");

            var keyName = "Id";
            var properties = GenerateListOfProperties(GetProperties);
            properties.ForEach(prop => { insertQuery.Append(prop != keyName ? $"{prop}," : string.Empty); });

            insertQuery
                .Remove(insertQuery.Length - 1, 1)
                .Append(") VALUES (");

            properties.ForEach(prop => {
                insertQuery.Append(prop != keyName ? $"@{prop}," : string.Empty);
            });

            insertQuery
                .Remove(insertQuery.Length - 1, 1)
                .Append(")");

            return insertQuery.ToString();
        }
        public string UpdateQuery()
        {
            var updateQuery = new StringBuilder($"UPDATE {TableName} SET ");
            var properties = GenerateListOfProperties(GetProperties);
            var keyName = "Id";
            properties.ForEach(property =>
            {
                if (!string.IsNullOrEmpty(keyName) && !property.Equals(keyName))
                    updateQuery.Append($"{property}=@{property},");
            });

            updateQuery.Remove(updateQuery.Length - 1, 1); //remove last comma
            if (!string.IsNullOrEmpty(keyName))
                updateQuery.Append($" WHERE {keyName}=@{keyName}");
            else if (properties.Contains("guid"))
                updateQuery.Append(" WHERE guid=@guid");
            else
                updateQuery.Append(" WHERE Id=@Id");

            return updateQuery.ToString();
        }
        private static string GetNameKey(IEnumerable<PropertyInfo> listOfProperties)
        {
            return (from prop in listOfProperties
                    let attributes = prop.GetCustomAttributes(typeof(DescriptionAttribute), false)
                    where attributes.Length > 0 && (attributes[0] as DescriptionAttribute).Description == "Key"
                    select prop.Name).SingleOrDefault();
        }
        private static List<string> GenerateListOfProperties(IEnumerable<PropertyInfo> listOfProperties)
        {
            return (from prop in listOfProperties
                    let attributes = prop.GetCustomAttributes(typeof(DescriptionAttribute), false)
                    where attributes.Length <= 0 || (attributes[0] as DescriptionAttribute)?.Description != "NotMapped"
                    select prop.Name).ToList();
        }
    }
}
