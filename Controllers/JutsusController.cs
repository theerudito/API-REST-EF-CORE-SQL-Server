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
    public class JutsusController : Controller
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public JutsusController(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<Jutsu>>> GetAll()
        {
            return await context.Jutsus.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] JutsuDTO jutsuDTO)
        {
            var jutsu = mapper.Map<Jutsu>(jutsuDTO);

            context.Add(jutsu);
            await context.SaveChangesAsync();

            return Ok();
        }
    }
}
