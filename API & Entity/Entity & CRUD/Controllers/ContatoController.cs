using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity___CRUD.Context;
using Entity___CRUD.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Entity___CRUD.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContatoController : ControllerBase
    {
        private readonly AgendaContext _context;
        public ContatoController(AgendaContext context)
        {
            _context = context;
        }
        [HttpPost]
        public IActionResult Create(Contato Contato)
        {
            _context.Add(Contato);
            _context.SaveChanges();
            return CreatedAtAction(nameof(ObterPorId), new {id = Contato.Id}, Contato);
        }

        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id)
        {   
            var contato = _context.Contatos.Find(id);
            if (contato == null)
            {
                return NotFound();
            }
            return Ok(contato);
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, Contato contato)
        {   
            var contatoQuery = _context.Contatos.Find(id);
            if (contatoQuery == null)
            {
                return NotFound();
            }
            contatoQuery.Nome = contato.Nome;
            contatoQuery.Telefone = contato.Telefone;
            contatoQuery.Ativo = contato.Ativo;
            _context.Contatos.Update(contatoQuery);
            _context.SaveChanges();
            return Ok(contatoQuery);
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            var contato = _context.Contatos.Find(id);
            if (contato == null)
            {
                return NotFound();
            }
            _context.Contatos.Remove(contato);
            _context.SaveChanges();
            return NoContent();
        }

        [HttpGet("ObterPorNome/{nome}")]
        public IActionResult ObterPorNome(string nome)
        {
            var contatos = _context.Contatos.Where(x => x.Nome.Contains(nome));
            return Ok(contatos);
        }
    }   
}