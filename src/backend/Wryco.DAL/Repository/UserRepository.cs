using Wryco.DAL.Entity;

namespace Wryco.DAL.Repository;

public class UserRepository: Repository<User>
{
    public UserRepository(ApplicationDbContext context) : base(context) { }
}
