using System;
using System.Collections;
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
    public class CategoriesController : ControllerBase
    {
        public CraftedContext Context { get; }
        public IMapper Mapper { get; }

        public CategoriesController(CraftedContext context, IMapper mapper)
        {
            Context = context;
            Mapper = mapper;
        }

        [HttpGet]
        [ApiConventionMethod(typeof(DefaultApiConventions),
                     nameof(DefaultApiConventions.Get))]
        public ActionResult<IEnumerable<CategoryDto>> Get()
        {
            var categories = Context.Categories.ToList();
            var dtos = Mapper.Map<IEnumerable<Category>, IEnumerable<CategoryDto>>(categories);
            return Ok(dtos);
        }

        [HttpGet("{id}")]
        [ApiConventionMethod(typeof(DefaultApiConventions),
                    nameof(DefaultApiConventions.Get))]
        public ActionResult<CategoryDto> Get(int id)
        {
            var category = Context.Categories.SingleOrDefault(c => c.Id == id);
            if (category == null)
            {
                return NotFound();
            }
            return Mapper.Map<CategoryDto>(category);
        }

        [HttpPost]
        [ApiConventionMethod(typeof(DefaultApiConventions), 
            nameof(DefaultApiConventions.Post))]
        public void Post([FromBody] CreatedCategoryDto category)
        {
            var dbCat = Mapper.Map<Category>(category);
            Context.Categories.Add(dbCat);
            Context.SaveChanges();
        }

        [HttpPut("{id}")]
        [ApiConventionMethod(typeof(DefaultApiConventions),
                    nameof(DefaultApiConventions.Put))]
        public IActionResult Put(int id,
             [FromBody] UpdatedCategoryDto category)
        {
            if (category == null)
            {
                return BadRequest();
            }

            var dbCat = Context.Categories.SingleOrDefault(c => c.Id == id);
            if (dbCat == null)
            {
                return NotFound();
            }
            Mapper.Map(category, dbCat);
            Context.SaveChanges();
            return NoContent();
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id,
            [FromBody] JsonPatchDocument<UpdatedCategoryDto> patchDocument)
        {
            if (patchDocument == null)
            {
                return BadRequest();
            }

            var dbCat = Context.Categories.SingleOrDefault(i => i.Id == id);
            if (dbCat == null)
            {
                return NotFound();
            }

            var itemToPatch = Mapper.Map<UpdatedCategoryDto>(dbCat);
            patchDocument.ApplyTo(itemToPatch);

            // TODO add validation
            Mapper.Map(itemToPatch, dbCat);
            Context.SaveChanges();
            return NoContent();
        }
    }
}
