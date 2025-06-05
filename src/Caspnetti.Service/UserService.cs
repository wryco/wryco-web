using Caspnetti.DAL;

namespace Caspnetti.Service;

public class UserService
{
    private readonly ApplicationDbContext _context;

    public UserService(ApplicationDbContext context)
    {
        _context = context;
    }
}