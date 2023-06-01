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
            return Ok(contato);
        }
        
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var contato = _context.Contatos.Find(id);

            if(contato != null)
            {
                return Ok(contato);
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
    }
}