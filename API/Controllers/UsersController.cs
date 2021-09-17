using Microsoft.AspNetCore.Mvc;
using System;
using API.Data;
using System.Collections.Generic;
using System.Linq;
using API;
using API.Entity;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        
        private readonly DataContext _context;
        public UsersController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers(){
            return await _context.Users.ToListAsync();
             
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<AppUser>> GetUsers(int Id){
            return await _context.Users.FindAsync(Id);
             
        }


    }
}