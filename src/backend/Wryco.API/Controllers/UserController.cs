using Wryco.DAL.Repository;
using Wryco.DAL.Entity;
using Microsoft.AspNetCore.Mvc;

namespace Wryco.API.Controllers;

[ApiController]
[Route("api/user")]
public class UserController : BaseController<UserRepository, User>
{
    public UserController(UserRepository repository) : base(repository) { }
}
