using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Crafted.Data;
using Crafted.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Crafted.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private CraftedContext Context { get; }
        private IMapper Mapper { get; }
        private UserManager<AppUser> UserManager { get; }


        public UsersController(CraftedContext context, IMapper mapper, UserManager<AppUser> userManager)
        {
            Context = context;
            Mapper = mapper;
            UserManager = userManager;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]RegistrationDto model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var userIdentity = Mapper.Map<RegistrationDto, AppUser>(model);

            var result = await UserManager.CreateAsync(userIdentity, model.Password);

            if (!result.Succeeded)
            {
                return BadRequest(result.Errors);
            }

            return new OkObjectResult("Account created");
        }

    }
}