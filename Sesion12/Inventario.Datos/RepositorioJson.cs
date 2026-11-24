using Inventario.Modelos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Inventario.Datos
{
    public class RepositorioJson : IRepositorioProductos
    {
        private readonly string _ruta;
        private readonly JsonSerializerOptions _opciones = new() { WriteIndented = true };

        public RepositorioJson(string ruta) => _ruta = ruta;

        public List<Categoria> ObtenerCategorias() => [new Categoria { Id = 1, Nombre = "General" }];

        public List<Producto> ObtenerTodos()
        {
            if (!File.Exists(_ruta)) return [];
            try
            {
                string json = File.ReadAllText(_ruta);
                return JsonSerializer.Deserialize<List<Producto>>(json) ?? [];
            }
            catch (JsonException)
            {
                
                File.Copy(_ruta, _ruta + ".danado", overwrite: true);
                return [];
            }
        }

        private void Guardar(List<Producto> lista)
        {
            string json = JsonSerializer.Serialize(lista, _opciones);
            File.WriteAllText(_ruta, json);
        }

        public Producto? BuscarPorCodigo(string codigo)
        {
            var lista = ObtenerTodos();
            return lista.FirstOrDefault(p => p.Codigo.Equals(codigo, StringComparison.OrdinalIgnoreCase));
        }

        public void Agregar(Producto producto)
        {
            var lista = ObtenerTodos();
            lista.Add(producto);
            Guardar(lista);
        }

        public void Actualizar(Producto producto)
        {
            var lista = ObtenerTodos();
            int indice = lista.FindIndex(p => p.Codigo.Equals(producto.Codigo, StringComparison.OrdinalIgnoreCase));
            if (indice >= 0)
            {
                lista[indice] = producto;
                Guardar(lista);
            }
        }

        public void Eliminar(string codigo)
        {
            var lista = ObtenerTodos();
            lista.RemoveAll(p => p.Codigo.Equals(codigo, StringComparison.OrdinalIgnoreCase));
            Guardar(lista);
        }
    }
}
