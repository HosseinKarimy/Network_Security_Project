namespace DataAccess;

public interface IRepository<T>
{
    public void Add(T entity);
    public void Update(T entity);
    public void Delete(T entity);
    public T GetById(int id);
    public List<T> GetAll();
}
