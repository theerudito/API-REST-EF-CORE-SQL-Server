using AutoMapper;
using EF_SQL_Server.DB_Context;
using EF_SQL_Server.DTO;
using EF_SQL_Server.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EF_SQL_Server.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class NarutoController : Controller
    {
        // INYECCION DE DEPENDENCIAS
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public NarutoController(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<Naruto>>> GetAll()
        {
            return await context.Characters.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Naruto>> GetById(int id)
        {
            return await context.Characters.FirstOrDefaultAsync(x => x.Id == id);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Naruto_DTO narutoDTO)
        {
            var naruto = mapper.Map<Naruto>(narutoDTO);
            context.Add(naruto);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put([FromBody] Naruto naruto, int id)
        {
            if (naruto.Id != id)
            {
                return BadRequest();
            }

            context.Entry(naruto).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var naruto = await context.Characters.FirstOrDefaultAsync(x => x.Id == id);
            if (naruto == null)
            {
                return NotFound();
            }

            context.Remove(naruto);
            await context.SaveChangesAsync();
            return Ok();
        }
    }
}
