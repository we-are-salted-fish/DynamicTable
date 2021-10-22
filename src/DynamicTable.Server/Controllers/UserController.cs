using DynamicTable.Server.Data;
using DynamicTable.Shared;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace DynamicTable.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IList<User>> Get(int page,int pageSize )
        {
            return UserService.UserQuery.Skip(page * pageSize).Take(pageSize).ToArray();
        }
    }
}
