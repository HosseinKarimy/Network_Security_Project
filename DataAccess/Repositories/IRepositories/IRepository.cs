namespace DataAccess.Repositories.IRepositories;

public interface IRepository<T>
{
    public void Add(T entity);
    public void Update(T entity);
    public void Delete(T entity);
    public List<T> GetAll();
}
