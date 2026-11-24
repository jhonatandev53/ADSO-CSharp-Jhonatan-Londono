using Inventario.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventario.Datos
{
    public interface IRepositorioProductos
    {
        List<Producto> ObtenerTodos();

        List<Categoria> ObtenerCategorias();
        Producto? BuscarPorCodigo(string codigo);
        void Agregar(Producto producto);
        void Actualizar(Producto producto);
        void Eliminar(string codigo);
    }
}
