using Microsoft.AspNetCore.Mvc;
using Caspnetti.Service;

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
    public String Get()
    {
        return "Hello, world c:";
    }
}
