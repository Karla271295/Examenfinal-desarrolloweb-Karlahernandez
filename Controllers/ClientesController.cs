using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ClientesApi.Models;

namespace ClientesApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ClientesController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost("CrearCliente")]
        public async Task<IActionResult> CrearCliente([FromBody] Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            await _context.SaveChangesAsync();
            return Ok(cliente);
        }

        [HttpGet("ListadoGeneral")]
        public async Task<IActionResult> ListadoGeneral()
        {
            var clientes = await _context.Clientes.OrderBy(c => c.Apellidos).ToListAsync();
            return Ok(clientes);
        }
    }
}
