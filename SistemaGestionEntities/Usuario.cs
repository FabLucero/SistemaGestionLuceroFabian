using System.ComponentModel.DataAnnotations;


namespace SistemaGestionEntities;

public class Usuario
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "El campo Nombre es requerido.")]
    [MaxLength(100, ErrorMessage = "El Nombre no puede tener más de 100 caracteres.")]
    public string Nombre { get; set; } = string.Empty;

    [Required(ErrorMessage = "El campo Apellido es requerido.")]
    [MaxLength(100, ErrorMessage = "El Apellido no puede tener más de 100 caracteres.")]
    public string Apellido { get; set; } = string.Empty;

    [Required(ErrorMessage = "El campo Nombre de Usuario es requerido.")]
    [MaxLength(100, ErrorMessage = "El Nombre de Usuario no puede tener más de 100 caracteres.")]
    public string NombreUsuario { get; set; } = string.Empty;

    [Required(ErrorMessage = "El campo Contraseña es requerido.")]
    [MaxLength(100, ErrorMessage = "La Contraseña no puede tener más de 100 caracteres.")]
    [MinLength(5, ErrorMessage = "La Contraseña debe tener al menos 5 caracteres.")]
    public string Contraseña { get; set; } = string.Empty;

    [Required(ErrorMessage = "El campo Email es requerido.")]
    [MaxLength(100, ErrorMessage = "El Email no puede tener más de 100 caracteres.")]
    [EmailAddress(ErrorMessage = "El Email no es una dirección de correo electrónico válida.")]
    public string Email { get; set; } = string.Empty;
}

