using Microsoft.AspNetCore.Mvc;
using ApiRest.Models;
using ApiRest.Data.Dtos;
using AutoMapper;

namespace ApiRest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmeController : ControllerBase
    {
        private DataContext _context;
        private IMapper _mapper;
 
        public FilmeController(DataContext context, IMapper mapper){
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult adiocionaFilme([FromBody]CreateFilmeDto filmeDto){

            Filme filme = _mapper.Map<Filme>(filmeDto);

            _context.Filmes.Add(filme);
            _context.SaveChanges();
            return CreatedAtAction(nameof(retornaFilmePorId), new {Id = filme.Id}, filme);
        }

        [HttpGet]
        public IActionResult retornaFilmes([FromQuery] string? titulo, int? classificacaoIndicativa = null){
            var query = from filmes in _context.Filmes select filmes;

            if(!string.IsNullOrEmpty(titulo)){
                query = query.Where(filmes =>  filmes.Titulo.Contains(titulo));
            }
            if(classificacaoIndicativa != null)
                query = query.Where(filmes => filmes.ClassificacaoIndicativa <= classificacaoIndicativa);

            return Ok( query.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult retornaFilmePorId(int id){
            Filme filme = _context.Filmes.FirstOrDefault(filme => filme.Id == id);
            if(filme != null){
                ReadFilmeDto filmeDto = _mapper.Map<ReadFilmeDto>(filme);
                return Ok(filmeDto);
            }
            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult atualizaFilme(int id, [FromBody]UpdateFilmeDto filmeDto){
            Filme filme = _context.Filmes.FirstOrDefault(filme => filme.Id == id);
            if(filme == null)
                return NotFound();
            
            _mapper.Map(filmeDto,filme);
            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult deletaFilme(int id){
            Filme filme = _context.Filmes.FirstOrDefault(filme => filme.Id == id);
            if(filme == null)
                return NotFound();
            
            _context.Remove(filme);
            return NoContent();
        }

    }
}