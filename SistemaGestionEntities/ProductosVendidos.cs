using System.ComponentModel.DataAnnotations;

namespace SistemaGestionEntities;

public class ProductosVendidos
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "El campo IdProducto es requerido.")]    
    public int IdProducto { get; set; }

    [Required(ErrorMessage = "El campo Stock es requerido.")]    
    public decimal Stock { get; set; }

    [Required(ErrorMessage = "El campo IdVenta es requerido.")]
    [Range(1, int.MaxValue, ErrorMessage = "El campo IdVenta debe ser mayor a 0.")]
    public int IdVenta { get; set; }

}
