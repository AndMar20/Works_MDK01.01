using System.Data;
using System.Data.SqlClient;
using System.Net;

namespace Library
{
    public static class DataAccessLayer
    {
        #region Свойства
        public static string ServerName { get; set; } = @"prserver\SQLEXPRESS";
        public static string DatabaseName { get; set; } = "ispp2109";
        public static string Login { get; set; } = "ispp2109";
        public static string Password { get; set; } = "2109";
        public static string ConnectionString
        {
            get
            {
                SqlConnectionStringBuilder builder = new()
                {
                    DataSource = ServerName,
                    UserID = Login,
                    Password = Password,
                    InitialCatalog = DatabaseName,
                    TrustServerCertificate = true
                };
                return builder.ConnectionString;
            }
        }
        #endregion

        #region LabWork45
        public static object GetValue(string query)
        {
            using SqlConnection connection = new(ConnectionString);
            connection.Open();

            SqlCommand command = new(query, connection);
            return command.ExecuteScalar();
        }

        public static DataTable GetTable(string query)
        {
            DataTable table = new();
            using SqlConnection connection = new(ConnectionString);
            connection.Open();

            using SqlDataAdapter adapter = new(query, connection);
            adapter.Fill(table);
            return table;
        }

        public static List<Book> GetBooks()
        {
            using SqlConnection connection = new(ConnectionString);
            connection.Open();

            string query = "SELECT * FROM Book";

            SqlCommand command = new(query, connection);

            var reader = command.ExecuteReader();

            List<Book> books = new();
            while (reader.Read())
            {
                Book book = new()
                {
                    Id = (int)reader["BookId"],
                    Title = (string)reader["Title"],
                    Price = Convert.ToDouble(reader["Price"])
                };
                books.Add(book);
            }
            return books;
        }
        #endregion

        #region LabWork46
        public static int GetChangedRowsCount(string query)
        {
            using SqlConnection connection = new(ConnectionString);
            connection.Open();

            SqlCommand command = new(query, connection);
            return command.ExecuteNonQuery();
        }

        public static bool IsUpdate(int bookId, decimal newPrice)
        {
            using SqlConnection connection = new(ConnectionString);
            connection.Open();

            string query = $"UPDATE Book SET Price = {newPrice} WHERE BookId = {bookId} ";

            SqlCommand command = new(query, connection);
            return command.ExecuteNonQuery() > 0;
        }

        public static DataTable GetTabelByName(string tableName)
        {
            DataTable table = new();

            using SqlConnection connection = new(ConnectionString);
            connection.Open();

            string query = $"SELECT * FROM {tableName}";

            using SqlDataAdapter adapter = new(query, connection);
            adapter.Fill(table);

            return table;
        }

        public static void UpdateTable(ref DataTable table, string tableName)
        {
            using SqlConnection connection = new(ConnectionString);
            connection.Open();

            var query = $"SELECT * FROM {tableName}";

            SqlDataAdapter adapter = new(query, connection);
            SqlCommandBuilder builder = new(adapter);
            adapter.Update(table);

            table.Clear();
            adapter.Fill(table);
        }
        #endregion

        #region LabWork47
        public static object GetCountLowerPrice(int price)
        {
            using SqlConnection connection = new(ConnectionString);
            connection.Open();

            var query = "SELECT COUNT(*) FROM Book WHERE Price < @maxPrice";
            SqlCommand command = new(query, connection);
            command.Parameters.AddWithValue("@maxPrice", price);

            return command.ExecuteScalar();
        }

        public static int AddRow(string query)
        {
            using SqlConnection connection = new(ConnectionString);
            connection.Open();

            SqlCommand command = new($"{query};SET @id=SCOPE_IDENTITY()", connection);
            SqlParameter lastId = new("@id", SqlDbType.Int);

            lastId.Direction = ParameterDirection.Output;
            command.Parameters.Add(lastId);

            command.ExecuteNonQuery();

            return Convert.ToInt32(lastId.Value);
        }

        public static DataTable GetGenreAndLowerPriceTable(int price, string genre)
        {
            DataTable table = new();
            using SqlConnection connection = new(ConnectionString);
            connection.Open();

            string query = "SELECT * FROM Book WHERE Price < @maxPrice AND Genre = @genre";

            using SqlDataAdapter adapter = new(query, connection);
            adapter.SelectCommand.Parameters.AddWithValue("@maxPrice", price);
            adapter.SelectCommand.Parameters.AddWithValue("@genre", genre);

            adapter.Fill(table);
            return table;
        }

        public static bool IsUpdateRow(int id, string title, int price)
        {
            using SqlConnection connection = new(ConnectionString);
            connection.Open();

            string query = "UPDATE Book SET Price = @price, Title= @title WHERE BookId = @id";

            using SqlCommand command = new(query, connection);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@title", title);
            command.Parameters.AddWithValue("@price", price);

            return command.ExecuteNonQuery() > 0;
        }
    }
    #endregion
}

