using Microsoft.AspNetCore.Mvc;
using ApiRest.Models;
using ApiRest.Data.Dtos;
using AutoMapper;

namespace ApiRest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DiretorController : ControllerBase
    {
        private DataContext _context;
        private IMapper _mapper;

        public DiretorController(DataContext context, IMapper mapper){
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult getDiretor(){
            return Ok( _context.Diretores);
        }

    }
}