using Caspnetti.DAL.Entity;
using Caspnetti.Service;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Caspnetti.API.Controllers;

[ApiController]
[Route("/")]
public class IndexController : ControllerBase
{
    private readonly UserService _userService;

    public IndexController(UserService userService)
    {
        _userService = userService;
    }

    [HttpGet(Name = "Index")]
    public IEnumerable<User> Get()
    {
        var users = _userService.Test();
        return users;
        // return "Hello, world c:";
    }
}
