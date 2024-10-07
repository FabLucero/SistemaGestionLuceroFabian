using Microsoft.EntityFrameworkCore;
using SistemaGestionData.Context;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionData.DataAccess;

namespace SistemaGestionBussiness.Services;

public class ProductosVendidosService
{

    private ProductoVendidoDataAccess _productoVendidoDataAccess;

    public ProductosVendidosService(ProductoVendidoDataAccess productoVendidoDataAccess)
    {
        _productoVendidoDataAccess = productoVendidoDataAccess;
    }

    public ProductosVendidos? ObtenerProductoVendido(int id)
    {

        return _productoVendidoDataAccess.ObtenerProductoVendido(id);
    }

    public List<ProductosVendidos> ListarProductosVendidos()
    {
        return _productoVendidoDataAccess.ListarProductosVendidos();
    }

    public void CrearProductoVendido(ProductosVendidos productov)
    {
        _productoVendidoDataAccess.CrearProductoVendido(productov);
    }

    public void ModificarProductoVendido(int id, ProductosVendidos productov)
    {
        _productoVendidoDataAccess.ModificarProductoVendido(id, productov);
    }

    public void EliminarProductoVendido(int id)
    {
        _productoVendidoDataAccess.EliminarProductoVendido(id);
    }
}