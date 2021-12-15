using Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DataAccessLayer
{


    public class CategoryDataAccess
    {
        private string _connectionString = "Server=(localdb)\\mssqllocaldb;Database=TicaretUygulamasiDB;Trusted_Connection=true";
        private SqlConnection _sqlConnection;
        private SqlCommand _sqlCommand;
        private SqlDataReader _sqlDataReader;
        public CategoryDataAccess()
        {
            _sqlConnection = new SqlConnection(_connectionString);
            _sqlCommand = _sqlConnection.CreateCommand();
        }

        public List<Category> GetCategories()
        {
            try
            {
                List<Category> categories = new List<Category>();
                string query = "Select * From Categories";
                _sqlCommand.CommandText = query;
                _sqlConnection.Open();
                _sqlDataReader = _sqlCommand.ExecuteReader();

                while (_sqlDataReader.Read())
                {
                    Category category = new Category
                    {

                        Id = Convert.ToInt32(_sqlDataReader["Id"]),
                        Name = _sqlDataReader["Name"].ToString(),
                        ParentId = _sqlDataReader.IsDBNull(2) ? null : Convert.ToInt32(_sqlDataReader["ParentId"]),
                        Description = _sqlDataReader["Description"].ToString(),
                        IsSale = Convert.ToBoolean(_sqlDataReader["IsSale"]),
                        TaxRate = Convert.ToDecimal(_sqlDataReader["TaxRate"])
                    };

                    categories.Add(category);
                }

                return categories;
            }

            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                _sqlConnection.Close();
            }

        }
    }
}





