using Inventario.Datos;
using Inventario.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventario.Servicios
{
    public class ServicioInventario
    {
        private readonly IRepositorioProductos _repositorio;

        public ServicioInventario(IRepositorioProductos repositorio) => _repositorio = repositorio;

        public List<Producto> Listar() =>
            _repositorio.ObtenerTodos().OrderBy(p => p.Nombre).ToList();

        public void Agregar(Producto producto)
        {
            var existente = _repositorio.BuscarPorCodigo(producto.Codigo);
            if (existente != null)
            {
                throw new InvalidOperationException($"Ya existe un producto registrado con el código '{producto.Codigo}'.");
            }
            _repositorio.Agregar(producto);
        }

        public void AgregarStock(string codigo, int cantidad)
        {
            Producto producto = _repositorio.BuscarPorCodigo(codigo)
                ?? throw new ArgumentException($"No existe un producto con el código '{codigo}'.");

            producto.AgregarStock(cantidad);
            _repositorio.Actualizar(producto);
        }

        public void Vender(string codigo, int cantidad)
        {
            Producto producto = _repositorio.BuscarPorCodigo(codigo)
                ?? throw new ArgumentException($"No existe un producto con el código '{codigo}'.");

            producto.Vender(cantidad); // Lanza StockInsuficienteException si sobrepasa el stock
            _repositorio.Actualizar(producto);
        }

        public List<Producto> ObtenerStockBajo(int limite = 5) =>
            _repositorio.ObtenerTodos().Where(p => p.Stock < limite).ToList();

        // Métodos para la Tarea
        public List<Producto> BuscarPorTexto(string texto)
        {
            return _repositorio.ObtenerTodos()
                .Where(p => p.Nombre.Contains(texto, StringComparison.OrdinalIgnoreCase) ||
                            p.Codigo.Contains(texto, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        public void Eliminar(string codigo)
        {
            Producto producto = _repositorio.BuscarPorCodigo(codigo)
                ?? throw new ArgumentException($"No se puede eliminar: no existe el producto '{codigo}'.");

            _repositorio.Eliminar(codigo);
        }
    }
}
