namespace DataAccess;

public interface IRepository<T>
{
    public void Add(T entity);
    public void Update(T entity);
    public void Delete(T entity);
    public T? Get(string Username);
}
