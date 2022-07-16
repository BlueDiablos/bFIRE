using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace bFIRE.Controllers;

[Route("User")]
[ApiController]
public class UserController : Controller
{

    [HttpGet]
    [Route("/Login/{Username}/{password}")]
    public JsonResult Login(string username, string password){
        
        return new JsonResult("Hello");
    }

}
