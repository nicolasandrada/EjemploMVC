using System.ComponentModel.DataAnnotations;

namespace EjemploMVC.Models
{
    public class Docente
    {
        [Key]
        public int id_docente { get; set; }

        [Required]
        [StringLength(50)]
        public string nombre { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat()]
        public DateTime fecha_nacimiento { get; set; }
    }
}
