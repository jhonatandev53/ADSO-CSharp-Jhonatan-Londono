using Inventario.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventario.Datos
{
    public class RepositorioMemoria : IRepositorioProductos
    {
        // Una lista en memoria RAM en lugar de un archivo JSON
        private readonly List<Producto> _productos = [];

        public List<Producto> ObtenerTodos() => _productos;

        public Producto? BuscarPorCodigo(string codigo)
        {
            return _productos.FirstOrDefault(p => p.Codigo.Equals(codigo, StringComparison.OrdinalIgnoreCase));
        }

        public void Agregar(Producto producto)
        {
            _productos.Add(producto);
        }

        public void Actualizar(Producto producto)
        {
            int indice = _productos.FindIndex(p => p.Codigo.Equals(producto.Codigo, StringComparison.OrdinalIgnoreCase));
            if (indice >= 0)
            {
                _productos[indice] = producto;
            }
        }

        public void Eliminar(string codigo)
        {
            _productos.RemoveAll(p => p.Codigo.Equals(codigo, StringComparison.OrdinalIgnoreCase));
        }
    }
}
