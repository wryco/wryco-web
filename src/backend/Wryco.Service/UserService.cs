using Wryco.DAL.Entity;
using Wryco.DAL.Repository;
using System.Collections.Generic;

namespace Wryco.Service;

public class UserService
{
    private readonly UserRepository _userRepository;

    public UserService(UserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public IEnumerable<User> Test()
    {
        var users = _userRepository.FindAll();
        return users;
    }
}
