using DataAccess.DBContext;
using DataAccess.Repositories.IRepositories;
using Models.DTO;
using System.Data.SQLite;

namespace DataAccess.Repositories;

public class ContactRepository : IContactRepository
{

    private readonly SQLiteConnection _sqLiteConnection;
    private readonly string _tableName = "Contacts";
    public ContactRepository()
    {
        _sqLiteConnection = new AppDbContext().SqliteConnection;
    }

    public void Add(ContactDTO entity)
    {
        using SQLiteConnection connection = new SQLiteConnection(_sqLiteConnection);
        connection.Open();
        using SQLiteCommand cmd = new(connection);
        cmd.CommandText = "INSERT INTO " + _tableName + " (Name, Number , Owner, Sign) VALUES (@Name, @Number , @Owner, @Sign)";
        cmd.Parameters.AddWithValue("@Name", entity.EncryptedName);
        cmd.Parameters.AddWithValue("@Number", entity.EncryptedNumber);
        cmd.Parameters.AddWithValue("@Owner", entity.EncryptedOwner);
        cmd.Parameters.AddWithValue("@Sign", entity.Sign);

        cmd.ExecuteNonQuery();
    }

    public void Delete(ContactDTO entity)
    {
        throw new NotImplementedException();
    }

    public List<ContactDTO> GetAll()
    {
        throw new NotImplementedException();
    }

    public ContactDTO GetById(int id)
    {
        throw new NotImplementedException();
    }

    public List<ContactDTO> GetByOwner(string owner)
    {
        using SQLiteConnection connection = new SQLiteConnection(_sqLiteConnection);
        connection.Open();
        using SQLiteCommand cmd = new(connection);
        cmd.CommandText = $"SELECT * FROM {_tableName} where Owner like @Owner";
        cmd.Parameters.AddWithValue("@Owner", owner);

        using SQLiteDataReader sqlite_datareader = cmd.ExecuteReader();
        List<ContactDTO> contactDTOs = [];

        while (sqlite_datareader.Read())
        {
            contactDTOs.Add(new ContactDTO
            {
                ID = sqlite_datareader.GetInt32(0),
                EncryptedName = sqlite_datareader.GetString(1),
                EncryptedNumber = sqlite_datareader.GetString(2),
                EncryptedOwner = sqlite_datareader.GetString(3),
                Sign = sqlite_datareader.GetString(4),
            });
        }

        return contactDTOs;
    }

    public void Update(ContactDTO entity)
    {
        throw new NotImplementedException();
    }
}
