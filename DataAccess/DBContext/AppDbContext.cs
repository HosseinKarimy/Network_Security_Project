using System.Data.SQLite;

namespace DataAccess.DBContext;

public class AppDbContext
{
    public SQLiteConnection SqliteConnection { get; private set; }
    public AppDbContext()
    {
        //C:\Users\hossein\source\repos\Network_Security_Project\WInFormUI\bin\Debug\net8.0-windows\DataBase.db
        string path = Path.Combine(Directory.GetCurrentDirectory(), "DataBase.db");

        string connectionString = $"Data Source={path};Version=3;";
        SqliteConnection = new SQLiteConnection(connectionString);

        if (!File.Exists(path))
        {
            CreateDatabase();
        }

    }

    private void CreateDatabase()
    {
        // Create the SQLite connection
        using SQLiteConnection connection = new(SqliteConnection);
        connection.Open();

        // Create the Contacts table
        using (SQLiteCommand command = new(connection))
        {
            command.CommandText = @"
                    CREATE TABLE IF NOT EXISTS ""Contacts"" (
                        ""ID"" INTEGER NOT NULL UNIQUE,
                        ""Name"" TEXT NOT NULL,
                        ""Number"" TEXT NOT NULL,
                        ""Owner"" TEXT NOT NULL,
                        ""Sign"" TEXT NOT NULL,
                        PRIMARY KEY(""ID"" AUTOINCREMENT)
                    );
                ";
            command.ExecuteNonQuery();
        }

        // Create the Users table
        using (SQLiteCommand command = new(connection))
        {
            command.CommandText = @"
                    CREATE TABLE IF NOT EXISTS ""Users"" (
                        ""ID"" INTEGER NOT NULL UNIQUE,
                        ""Username"" TEXT NOT NULL UNIQUE,
                        ""Password"" TEXT NOT NULL,
                        PRIMARY KEY(""ID"" AUTOINCREMENT)
                    );
                ";
            command.ExecuteNonQuery();
        }
    }
}
