using Inventario.Servicios;

namespace Inventario.Escritorio;

public partial class FormReportes : Form
{
    private readonly ServicioInventario _servicio;

    public FormReportes(ServicioInventario servicio)
    {
        InitializeComponent();
        _servicio = servicio;
        CargarReportes();
    }

    private void CargarReportes()
    {
        // Tabla 1: Productos más valiosos (ordenados por precio de mayor a menor)
        dgvMasValiosos.DataSource = _servicio.Listar()
            .OrderByDescending(p => p.Precio * p.Stock)
            .Take(5) // Los 5 más valiosos
            .ToList();

        // Tabla 2: Productos con stock bajo (< 5)
        dgvStockBajo.DataSource = _servicio.ObtenerStockBajo();
    }

    
}