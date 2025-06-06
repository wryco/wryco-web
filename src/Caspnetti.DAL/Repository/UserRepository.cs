using Caspnetti.DAL.Entity;

namespace Caspnetti.DAL.Repository;

public class UserRepository: Repository<User>
{
    public UserRepository(ApplicationDbContext context) : base(context) { }


}
