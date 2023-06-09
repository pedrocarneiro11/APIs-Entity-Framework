using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using _10_Introducao_a_APIs_com_Csharp.Context;
using _10_Introducao_a_APIs_com_Csharp.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace _10_Introducao_a_APIs_com_Csharp.Controllers
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
        public IActionResult Create(Contato contato)
        {
            _context.Add(contato);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetByID), new { id = contato.Id }, contato);
        }
        
        [HttpGet("{id}")]
        public IActionResult GetByID(int id)
        {
            var contato = _context.Contatos.Find(id);

            if(contato != null)
            {
                int Id = id;
                string nome = contato.Nome;
                return Ok(contato);
            } 
            else
            {
                return NotFound();
            }            
        }
        
        [HttpGet("ObterPorNome")]
        public IActionResult Get(string Nome)
        {
            var contatos = _context.Contatos.Where(x => x.Nome.Contains(Nome));

            if(contatos != null)
            {
                string nome = Nome;
                return Ok(contatos);
            } 
            else
            {
                return NotFound();
            }            
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Contato contato)
        {
            var contatoBanco = _context.Contatos.Find(id);

            if (contatoBanco == null)
            {
                return NotFound();
            }
            else
            {
                contatoBanco.Nome = contato.Nome;
                contatoBanco.Telefone = contato.Telefone;
                contatoBanco.Ativo = contato.Ativo;

                _context.Contatos.Update(contatoBanco);
                _context.SaveChanges();

                return Ok(contatoBanco);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var contatoBanco = _context.Contatos.Find(id);

            if (contatoBanco == null)
            {
                return NotFound();
            }
            else 
            {
                _context.Contatos.Remove(contatoBanco);
                _context.SaveChanges();

                return NoContent();
            }
        }
    }
}