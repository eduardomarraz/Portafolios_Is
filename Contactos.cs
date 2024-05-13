using System.ComponentModel.DataAnnotations;
namespace R_CV;
public class Contactos{
   public int Id { get; set; }
   [StringLength(50, ErrorMessage = "Máximo 50 caracteres")]
   public string Nombre { get; set; }
   [StringLength(50, ErrorMessage = "Máximo 50 caracteres")]
   public string Correo { get; set; }
   [StringLength(500, ErrorMessage = "Máximo 500 caracteres")]
   public string Mensaje { get; set; }}

