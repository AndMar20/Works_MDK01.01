using System.Data;

namespace DataAccessLayer
{
    public class DataAccessLayer
    {
        public static class DataAccessLayer
        {
            //Task1
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


            //Task2
            public static object GetChengedValue(string query)
            {
                object result = null;
                try
                {
                    using SqlConnection connection = new(ConnectionString);
                    connection.Open();

                    SqlCommand command = new(query, connection);

                    result = command.ExecuteScalar();
                }
                catch (SqlException)
                {
                    throw new Exception("Ошибка выполнения SQL-запроса");
                }
                catch (Exception)
                {
                    throw new Exception("Команжа не может быть пустой");
                }
                return result;
            }

            //Task3
            public static DataTable GetTabel(string query)
            {
                DataTable table = new();
                try
                {
                    using SqlConnection connection = new(ConnectionString);
                    connection.Open();

                    using SqlDataAdapter adapter = new(query, connection);
                    adapter.Fill(table);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Ошибка выполнения SQL-запроса: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
                return table;
            }

            //Task4
            public static List<Book> GetBooks(string query)
            {
                using SqlConnection connection = new(ConnectionString);
                connection.Open();

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
        }
}
