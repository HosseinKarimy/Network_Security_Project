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
    }
}
