using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Crafted.Data;
using Crafted.DTO;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace Crafted.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiConventionType(typeof(DefaultApiConventions))]
    [ApiController]
    public class MenuItemsController : ControllerBase
    {
        private CraftedContext Context { get; }
        private IMapper Mapper { get; }

        public MenuItemsController(CraftedContext context, IMapper mapper)
        {
            Context = context;
            Mapper = mapper;
        }

        [HttpGet]
        [ApiConventionMethod(typeof(DefaultApiConventions),
                     nameof(DefaultApiConventions.Get))]
        public ActionResult<IEnumerable<CreatedMenuItemDto>> Get()
        {
            var menuItems = Context.MenuItems.ToList();
            var dtos = Mapper.Map<IEnumerable<MenuItem>, IEnumerable<CreatedMenuItemDto>>(menuItems);
            return Ok(dtos);
        }

        [HttpGet("{id}")]
        [ApiConventionMethod(typeof(DefaultApiConventions),
                     nameof(DefaultApiConventions.Get))]
        public ActionResult<MenuItemDto> Get(int id)
        {
            var item = Context.MenuItems.SingleOrDefault(i => i.Id == id);
            if (item == null)
            {
                return NotFound();
            }
            var dto = Mapper.Map<MenuItemDto>(item);
            return Ok(dto);
        }

        [HttpPost]
        [ApiConventionMethod(typeof(DefaultApiConventions),
                     nameof(DefaultApiConventions.Post))]
        public void Post([FromBody]CreatedMenuItemDto menuItem)
        {
            var dbItem = Mapper.Map<MenuItem>(menuItem);
            Context.MenuItems.Add(dbItem);
            Context.SaveChanges();
        }

        [HttpPut("{id}")]
        [ApiConventionMethod(typeof(DefaultApiConventions),
                     nameof(DefaultApiConventions.Put))]
        public IActionResult Put(int id,
            [FromBody] UpdatedMenuItemDto menuItem)
        {
            if (menuItem == null)
            {
                return BadRequest();
            }

            var dbItem = Context.MenuItems.SingleOrDefault(i => i.Id == id);
            if (dbItem == null)
            {
                return NotFound();
            }
            Mapper.Map(menuItem, dbItem);
            Context.SaveChanges();
            return NoContent();
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, 
            [FromBody] JsonPatchDocument<UpdatedMenuItemDto> patchDoc)
        {
            if (patchDoc == null)
            {
                return BadRequest();
            }

            var dbItem = Context.MenuItems.SingleOrDefault(i => i.Id == id);
            if (dbItem == null)
            {
                return NotFound();
            }

            var itemToPatch = Mapper.Map<UpdatedMenuItemDto>(dbItem);
            patchDoc.ApplyTo(itemToPatch);

            // add validation
            Mapper.Map(itemToPatch, dbItem);
            Context.SaveChanges();
            return NoContent();
        }

    }
}