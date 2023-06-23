using ListaCompras.Modelos;
using Microsoft.EntityFrameworkCore;

namespace ListaCompras.Data
{
    public class ListaComprasService : IListaComprasService
    {
        private readonly ListaComprasContext _context;
        public ListaComprasService(ListaComprasContext context)
        {
            _context = context;
        }
        public async Task<bool> ActulizarListaCompras(Modelos.ListaCompras listaCompras)
        {
            _context.Entry(listaCompras).State = EntityState.Modified;
            return await _context.SaveChangesAsync() >0;
        }

        public async Task<bool> EliminarActulizarListaCompras(int Id)
        {
            var ListaCompras = await _context.ListaCompras.FindAsync(Id);
            _context.ListaCompras.Remove(ListaCompras);
            return await _context.SaveChangesAsync() >0;
        }

        public async Task<bool> GuardarListaCompras(Modelos.ListaCompras listacompras)
        {
            if (listacompras.ListaComprasId>0)
            {
                return await ActulizarListaCompras(listacompras);
            }
            else
            {
                return await InsertarListaCompras(listacompras);
            }
        }

        public async Task<bool> InsertarListaCompras(Modelos.ListaCompras listaCompras)
        {
            _context.ListaCompras.Add(listaCompras);
            return await _context.SaveChangesAsync()>0;
        }

        public async Task<Modelos.ListaCompras> ObtenerListaCompraDetalles(int Id)
        {
            return await _context.ListaCompras.FindAsync(Id);
        }

        public async Task<IEnumerable<Modelos.ListaCompras>> ObtenerTodosLosArticulos()
        {
            return await _context.ListaCompras.ToListAsync();
        }
    }
}
