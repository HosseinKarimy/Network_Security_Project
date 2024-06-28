using Models.DTO;

namespace DataAccess.Repositories.IRepositories;

public interface IContactRepository : IRepository<ContactDTO>
{
    public List<ContactDTO> GetByOwner(string owner);
}
