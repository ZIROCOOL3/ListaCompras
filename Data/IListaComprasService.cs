namespace ListaCompras.Data
{
    public interface IListaComprasService
    {
        Task<IEnumerable<Modelos.ListaCompras>> ObtenerTodosLosArticulos();
        Task<Modelos.ListaCompras> ObtenerListaCompraDetalles(int Id);
        Task<bool> InsertarListaCompras(Modelos.ListaCompras listaCompras);
        Task<bool> ActulizarListaCompras(Modelos.ListaCompras listaCompras);
        Task<bool> EliminarActulizarListaCompras(int Id);

        Task<bool> GuardarListaCompras(Modelos.ListaCompras listacompras);

    }
}
