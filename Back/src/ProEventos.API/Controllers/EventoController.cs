using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _eventos = new Evento[] {

                new Evento()
                {
                EventoId = 1,
                Tema = "Teste evento 1",
                Local = "SP",
                Lote = "1º Lote",
                QtdPessoa = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString(),
                ImageURL = "foto.img"
            },
                new Evento()
                {
                EventoId = 2,
                Tema = "Teste evento 2",
                Local = "RJ",
                Lote = "2º Lote",
                QtdPessoa = 150,
                DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
                ImageURL = "foto1.img"
            }

            };

        [HttpGet]
        public IEnumerable<Evento> GetAllEventos()
        {
            return _eventos;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetEventoById(int id)
        {
            return _eventos.Where(Evento => Evento.EventoId == id);
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo de Put com id = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo de Delete com id = {id}";
        }

    }
}
