using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{

    [ApiController]
    [Route("api/[controller]")] //  /api/users esto es un endpoint

    public class UsersController : ControllerBase
    {
        //variables goblales para un atributo privado ponen _ seguido de la palabra
        private readonly DataContext _context;

        //creacion del constructor y para eso se hace una inyeccion de dependencia
        public UsersController(DataContext context)
        {
            _context = context; // al poner _context se quita el this.context y se deja _context
        }

        //este metodo es una APi que va a retornar una lista de usuarios de tipo appUser -- GetUsers
        [HttpGet]

        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            var users = await _context.Users.ToListAsync(); //usamos wait para decirle al metodo que espere hasta que se compleete
            return users;

        }

        //metodo para obtener un usario en particular
        [HttpGet("{id}")]

        public async Task<ActionResult<AppUser>> GetUser(int id)
        {
            var user = await _context.Users.FindAsync(id);
            return user;
        }

    }
}