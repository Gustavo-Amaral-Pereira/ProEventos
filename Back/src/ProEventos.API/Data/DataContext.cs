using Microsoft.EntityFrameworkCore;
using ProEventos.API.Models;

namespace ProEventos.API.Data
{

    /// <summary>
    /// Lista de classes para serem referenciadas do dba
    /// </summary>
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        /// <summary>
        /// Adicionar a classe a ser integrada com o dba
        /// </summary>
        public DbSet<Evento> Eventos { get; set; }
    }
}