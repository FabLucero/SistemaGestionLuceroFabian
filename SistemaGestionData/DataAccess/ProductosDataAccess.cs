using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionEntities;
using SistemaGestionData.Context;

namespace SistemaGestionData.DataAccess;

public class ProductosDataAccess
{

    private CoderhouseContext _context;

    public ProductosDataAccess()
    {
        _context = new CoderhouseContext();
    }

    public Producto? GetOneProduct(int id)
    {
        return _context.Productos.FirstOrDefault(producto => producto.Id == id);
    }

    public List<Producto> GetProductBy(string filtro)
    {
        return _context.Productos
            .Where(producto => producto.Descripcion.Contains(filtro))           
            .ToList();
    }

    public List<Producto> ListProducts()
    {
        return _context.Productos.ToList();
    }

    public void InsertProduct(Producto producto)
    {
        _context.Productos.Add(producto);
        _context.SaveChanges();
    }

    public void UpdateProduct(int id, Producto producto)
    {
        var productoToUpdate = GetOneProduct(id);
        if (productoToUpdate != null)
        {
            productoToUpdate.Descripcion   = producto.Descripcion;
            productoToUpdate.Categoria     = producto.Categoria;
            productoToUpdate.Stock         = producto.Stock;
            productoToUpdate.PrecioCompra  = producto.PrecioCompra;
            productoToUpdate.PrecioVenta   = producto.PrecioVenta;
            productoToUpdate.TotalProducto = producto.TotalProducto;
            _context.SaveChanges();
        }
    }

    public void DeleteProduct(int id)
    {
        var producto = GetOneProduct(id);
        if (producto != null)
        {
            _context.Productos.Remove(producto);
            _context.SaveChanges();
        }
    }

}
