using api_test_bco.Models1;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api_test_bco.Controllers
{
    [ApiController]
    [Route("Productos")]
    public class HomeController : ControllerBase
    {
        
        private readonly _context context;
        public HomeController(_context context)
        {
            this.context = context;
        }


        [HttpGet]
        [Route("productosList")]
        public async Task<ActionResult<List<Producto>>> ListaProductos()
        {
            try
            {
                var res = await context.Producto.ToListAsync();
                return res;

            }
            catch
            {
                throw;
            }
        }
    }
}
