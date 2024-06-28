using DataAccess.DBContext;
using DataAccess.Repositories.IRepositories;
using Models.DTO;
using System.Data.SQLite;

namespace DataAccess.Repositories;

public class UserRepository : IUserRepository
{
    private readonly SQLiteConnection _sqLiteConnection;
    private readonly string _tableName = "Users";
    public UserRepository()
    {
        _sqLiteConnection = new AppDbContext().SqliteConnection;
    }

    public void Add(UserDTO entity)
    {
        using SQLiteConnection connection = new SQLiteConnection(_sqLiteConnection);
        connection.Open();
        using SQLiteCommand cmd = new(connection);
        cmd.CommandText = "INSERT INTO " + _tableName + " (Username, Password) VALUES (@Username, @Password)";
        cmd.Parameters.AddWithValue("@Username", entity.Username);
        cmd.Parameters.AddWithValue("@Password", entity.HashedPassword);

        cmd.ExecuteNonQuery();
    }

    public void Delete(UserDTO entity)
    {
        throw new NotImplementedException();
    }

    public List<UserDTO> GetAll()
    {
        throw new NotImplementedException();
    }

    public UserDTO GetById(int id)
    {
        throw new NotImplementedException();
    }

    public UserDTO? GetByUsername(string Username)
    {
        using SQLiteConnection connection = new SQLiteConnection(_sqLiteConnection);
        connection.Open();
        using SQLiteCommand cmd = new(connection);
        cmd.CommandText = $"SELECT ID, Username, Password FROM {_tableName} where Username like @Username";
        cmd.Parameters.AddWithValue("@Username", Username);

        using SQLiteDataReader sqlite_datareader = cmd.ExecuteReader();
        UserDTO? user = null;

        if (sqlite_datareader.Read())
        {
            user = new UserDTO
            {
                ID = sqlite_datareader.GetInt32(0),
                Username = sqlite_datareader.GetString(1),
                Password = sqlite_datareader.GetString(2)
            };
        }

        return user;
    }

    public void Update(UserDTO entity)
    {
        throw new NotImplementedException();
    }
}
