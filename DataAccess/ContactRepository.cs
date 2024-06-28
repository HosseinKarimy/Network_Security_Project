﻿using Models.DTO;
using System.Data.SQLite;

namespace DataAccess;

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
        cmd.Parameters.AddWithValue("@Name", entity.Name);
        cmd.Parameters.AddWithValue("@Number", entity.Number);
        cmd.Parameters.AddWithValue("@Owner", entity.Owner);
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

    public void Update(ContactDTO entity)
    {
        throw new NotImplementedException();
    }
}