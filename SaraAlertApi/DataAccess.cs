using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;


namespace SaraAlertApi
{
    public class DataAccess
    {

        private IDatabaseConfig Config { get; set; }

        public DataAccess(IDatabaseConfig config)
        {
            Config = config;
        }



        public List<ReturningTravelersExtract> GetReturningTravelers()
        {
            var results = new List<ReturningTravelersExtract>();

            var fields = GetFields<ReturningTravelersExtract>();

            using (var cnn = new SqlConnection(GetConnectionString()))
            using (var cmd = new SqlCommand())
            {
                cnn.Open();
                cmd.Connection = cnn;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "dbo.ExtractReturningTravelersDataForSaraAlert";
                cmd.Parameters.Add("SurveyId", System.Data.SqlDbType.NVarChar).Value = Config.SurveyID;

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var record = new ReturningTravelersExtract();

                        foreach (var field in fields)
                        {
                            SetReaderValue(reader, record, field);
                            // record.FirstName = (string)reader["First Name"];
                        }

                        results.Add(record);
                    }
                }
            }

            return results;
        }

        #region utilties 

        private string GetConnectionString()
        {
            var cnnStringBuilder = new SqlConnectionStringBuilder()
            {
                DataSource = Config.ServerName,
                InitialCatalog = Config.DatabaseName,
                IntegratedSecurity = true
            };

            return cnnStringBuilder.ToString();
        }

        private IEnumerable<PropertyMetadata> GetFields<T>()
        {

            var props = typeof(T).GetProperties();

            var list = from prop in props
                       where Attribute.IsDefined(prop, typeof(ColumnAttribute))
                       let attr = prop.GetCustomAttribute<ColumnAttribute>()
                       select new PropertyMetadata()
                       {
                           ColumnName = attr.Name,
                           PropertyName = prop.Name,
                           PropertyType = prop.PropertyType,
                           PropertyInfo = prop
                       };

            return list;
        }

        private void SetReaderValue<T>(SqlDataReader reader, T obj, PropertyMetadata prop)
        {
            //only load if we have a valid reader and column name
            if (DBNull.Value.Equals(reader[prop.ColumnName])) return;


            try
            {
                var propType = Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType;

                var safeValue = reader[prop.ColumnName] == null ? null :
                                Convert.ChangeType(reader[prop.ColumnName], propType);

                prop.PropertyInfo.SetValue(obj, safeValue, null);
            }
            catch (Exception)
            {
                //no handling; just don't set the value
            }

        }

        #endregion

    }

}

