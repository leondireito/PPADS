using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using RecommendAPI.Data;
using RecommendAPI.Entities;
using System.Linq;
using Microsoft.AspNetCore.Authorization;

namespace RecommendAPI.Controllers
{

    public class UsersController : BaseApiController
    {
        private readonly DataContext context;

        public UsersController(DataContext context)
        {
            this.context = context;
        }

        [HttpGet]
        [AllowAnonymous]
        public ActionResult<IEnumerable<AppUser>> GetUsers()
        {
            return context.Users.ToList();

        }

        [Authorize]
        [HttpGet("{id}")]
        public ActionResult<AppUser> GetUser(int id)
        {
            return context.Users.Find(id);

        }
    }
}