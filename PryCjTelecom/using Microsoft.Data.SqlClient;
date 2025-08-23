using Microsoft.Data.SqlClient;

string connectionString = "Data Source=161.132.37.248;Initial Catalog=JC_Db;Persist Security Info=True;User ID=SA;Password=AuT1iQS6Gxp9ysX;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False";

using (SqlConnection connection = new SqlConnection(connectionString))
{
    try
    {
        connection.Open();
        Console.WriteLine("Conexión exitosa a la base de datos.");
        // Aquí puedes ejecutar tus comandos SQL
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error al conectar: {ex.Message}");
    }
}