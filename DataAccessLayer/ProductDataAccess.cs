using Entities;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class ProductDataAccess
    {
        public ConnectionDataAccess _cnnacs;
        string query;
        //SqlCommand _cmd = new SqlCommand();
        SqlConnection _con = new SqlConnection();
        
        public int Insert(Product product)
        {
            SqlConnection connection = new SqlConnection("Server=(localdb)\\mssqllocaldb;Database=TicaretUygulamasiDB;Trusted_Connection=true");
            SqlCommand command = connection.CreateCommand();

            string query = " INSERT INTO [dbo].[Products] ([Name] ,[Description] ,[UnitPrice] ,[Stock] ,[StockUnit] ,[IsSale] ,[CategoryId] ,[SupplierId]) VALUES (@Name ,@Description ,@UnitPrice ,@Stock ,@StockUnit ,@IsSale ,@CategoryId ,@SupplierId)";

            command.CommandText = query;

            command.Parameters.Clear();
            command.Parameters.AddWithValue("@Name", product.Name);
            command.Parameters.AddWithValue("@Description", product.Description);
            command.Parameters.AddWithValue("@UnitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@Stock", product.Stock);
            command.Parameters.AddWithValue("@StockUnit", product.StockUnit);
            command.Parameters.AddWithValue("@IsSale", product.IsSale);
            command.Parameters.AddWithValue("@CategoryId", product.CategoryId);
            command.Parameters.AddWithValue("@SupplierId", product.SupplierId);

            connection.Open();
            int result = command.ExecuteNonQuery();
            connection.Close();

            return result;
        }
        public int Update(Product product, int productid)
        {
            query = "UPDATE Products SET Name=@Name,Description=@Description,UnitPrice=@UnitPrice,Stock=@Stock,StockUnit=@StockUnit,IsSale=@IsSale,CategoryId=@CategoryId,SupplierId=@SupplierId WHERE Id=@Id";

            _cnnacs = new ConnectionDataAccess(query);

            _cnnacs._cmd.Parameters.Clear();
            _cnnacs._cmd.Parameters.AddWithValue("@Id", productid);
            _cnnacs._cmd.Parameters.AddWithValue("@Name", product.Name);
            _cnnacs._cmd.Parameters.AddWithValue("@Description", product.Description);
            _cnnacs._cmd.Parameters.AddWithValue("@UnitPrice", product.UnitPrice);
            _cnnacs._cmd.Parameters.AddWithValue("@Stock", product.Stock);
            _cnnacs._cmd.Parameters.AddWithValue("@StockUnit", product.StockUnit);
            _cnnacs._cmd.Parameters.AddWithValue("@IsSale", product.IsSale);
            _cnnacs._cmd.Parameters.AddWithValue("@CategoryId", product.CategoryId);
            _cnnacs._cmd.Parameters.AddWithValue("@SupplierId", product.SupplierId);

            if (_cnnacs._conn.State != ConnectionState.Open)
            {
                _cnnacs._conn.Open();
            }
            int affectedRows = _cnnacs._cmd.ExecuteNonQuery();

            if (_cnnacs._conn.State != ConnectionState.Closed)
            {
                _cnnacs._conn.Close();

            }
            return affectedRows;

        }
        public int Delete(Product product, int productid)
        {
            query = "DELETE  FROM Products WHERE Id=@Id";

            _cnnacs = new ConnectionDataAccess(query);

            _cnnacs._cmd.Parameters.Clear();
            _cnnacs._cmd.Parameters.AddWithValue("@Id", productid);


            if (_cnnacs._conn.State != ConnectionState.Open)
            {
                _cnnacs._conn.Open();
            }
            int affectedRows = _cnnacs._cmd.ExecuteNonQuery();

            if (_cnnacs._conn.State != ConnectionState.Closed)
            {
                _cnnacs._conn.Close();

            }
            return affectedRows;

        }








    }
}
