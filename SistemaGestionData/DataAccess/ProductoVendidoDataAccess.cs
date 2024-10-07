using SistemaGestionData.Context;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionData.DataAccess;
public class ProductoVendidoDataAccess
{
    private CoderhouseContext _context;

    public ProductoVendidoDataAccess()
    {
        _context = new CoderhouseContext();
    }

    public ProductosVendidos? ObtenerProductoVendido(int id)
    {
        return _context.ProductosVendidos.FirstOrDefault(productov => productov.Id == id);
    }

    public List<ProductosVendidos> ListarProductosVendidos()
    {
        return _context.ProductosVendidos.ToList();
    }

    public void CrearProductoVendido(ProductosVendidos productov)
    {
        _context.ProductosVendidos.Add(productov);
        _context.SaveChanges();
    }

    public void ModificarProductoVendido(int id, ProductosVendidos productov)
    {
        var productovToUpdate = ObtenerProductoVendido(id);
        if (productovToUpdate != null)
        {
            productovToUpdate.Id         = productov.Id;
            productovToUpdate.IdProducto = productov.IdProducto;
            productovToUpdate.Stock      = productov.Stock;
            productovToUpdate.IdVenta    = productov.IdVenta;            
            _context.ProductosVendidos.Update(productovToUpdate);
            _context.SaveChanges();
        }

    }

    public void EliminarProductoVendido(int id)
    {
        var productov = ObtenerProductoVendido(id);
        if (productov != null)
        {
            _context.ProductosVendidos.Remove(productov);
            _context.SaveChanges();
        }
    }

}