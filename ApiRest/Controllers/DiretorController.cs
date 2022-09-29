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
            return Ok(_context.Diretores);
        }

        [HttpGet("{id}")]
        public IActionResult getDiretorById(int id){
            try{
                var diretor = _context.Diretores.Find(id);
                if(diretor != null)
                    return Ok( _mapper.Map<ReadDiretorDto>(diretor));
                return NotFound();
            }catch(Exception ex){
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult createDiretor([FromBody] CreateDiretorDto diretorDto){
            try{
                var diretor = _mapper.Map<Diretor>(diretorDto);
                _context.Add(diretor);
                _context.SaveChanges();
                return CreatedAtAction( nameof(getDiretorById), new {id = diretor.Id}, diretor);
            }catch(Exception ex){
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult updateDiretor(int id,[FromBody] UpdateDiretorDto diretorDto){
            try{
                var diretor = _context.Diretores.Find(id);
                if(diretor == null)
                    return NotFound();
                diretor.Nome = diretorDto.Nome;
                _context.Update(diretor);
                _context.SaveChanges();
                return Ok(diretor);
            }catch(Exception ex){
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult deleteDiretor(int id){
            try{
                var diretor = _context.Diretores.Find(id);
                if(diretor == null)
                    return NotFound();
                _context.Remove(diretor);
                _context.SaveChanges();
                return NoContent();
            }catch(Exception ex){
                return BadRequest(ex.Message);
            }
        }

    }
}