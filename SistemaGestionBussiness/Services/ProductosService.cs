using SistemaGestionData.DataAccess;
using SistemaGestionEntities;

namespace SistemaGestionBussiness.Services;

public class ProductosService
{
    private ProductosDataAccess _productosDataAccess;

    public ProductosService(ProductosDataAccess productosDataAccess)
    {
        _productosDataAccess = productosDataAccess;
    }

    public List<Producto> ListProducts()
    {
        return _productosDataAccess.ListProducts();
    }

    public List<Producto> GetProductBy(string filtro)
    {
        return _productosDataAccess.GetProductBy(filtro);
    }

    public Producto? GetOneProduct(int id)
    {
        return _productosDataAccess.GetOneProduct(id);
    }

    public void InsertProduct(Producto producto)
    {
        _productosDataAccess.InsertProduct(producto);
    }

    public void UpdateProduct(int id, Producto producto)
    {
        _productosDataAccess.UpdateProduct(id, producto);
    }

    public void DeleteProduct(int id)
    {
        _productosDataAccess.DeleteProduct(id);
    }


    public void UpdateTotalProduct(int id)
    {
        var producto = GetOneProduct(id);
        if (producto != null)
        {
            producto.TotalProducto = producto.Stock * producto.PrecioVenta;
            _productosDataAccess.UpdateProduct(id, producto);
        }
    }

    public void UpdateTotalProducts()
    {
        var productos = ListProducts();
        foreach (var producto in productos)
        {
            producto.TotalProducto = producto.Stock * producto.PrecioVenta;
            _productosDataAccess.UpdateProduct(producto.Id, producto);
        }
    }

}
