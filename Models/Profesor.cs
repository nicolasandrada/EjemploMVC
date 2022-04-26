
using System.ComponentModel.DataAnnotations;

namespace EjemploMVC.Models;


public class Profesor
{
    [Key]
    public int id { get; set; }
    
    [Required]
    public string nombre { get; set; }

    public string apellido { get; set; }

    public DateTime fecha_nac { get; set; }

    
}
