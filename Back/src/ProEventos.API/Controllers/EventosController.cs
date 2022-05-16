using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Data;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventosController : ControllerBase
    {
        private readonly DataContext _context;

        /// <summary>
        /// Inicialização do context(verificar Data/DataContext.cs para lista de classes )
        /// </summary>
        /// <param name="context"></param>
        public EventosController(DataContext context)
        {
            this._context = context;
        }

        /// <summary>
        /// Buscar todos os Eventos
        /// </summary>
        /// <returns>Lista com todos os eventos na lista</returns>
        [HttpGet]
        public IEnumerable<Evento> GetAllEventos()
        {
            return _context.Eventos;
        }

        /// <summary>
        /// Buscar Evento por id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Evento com o id do parâmetro</returns>
        [HttpGet("{id}")]
        public Evento GetEventoById(int id)
        {
            return _context.Eventos.FirstOrDefault(Evento => Evento.EventoId == id);
        }
    }
}