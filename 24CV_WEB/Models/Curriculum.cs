using System.ComponentModel.DataAnnotations;
namespace _24CV_WEB.Models
{
    public class Curriculum
    {
        [Required(ErrorMessage = "El campo nombre es requerido.")]
        [StringLength(50, ErrorMessage = "Minimo 50 caracteres.")]
        public string Nombre { get; set; }
        public string Apellidos { get; set; }

        [Required(ErrorMessage = "El campo CURP es requerido.")]
        public string CURP { get; set; }
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "La fecha de nacimiento es obligatoria")]
        public DateTime FechaNacimiento { get; set; }
        public string Dirección { get; set; }
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "El email es requerido")]
        public string Email { get; set; }
        [Range(0,100)]
        public int PorcentajeIngles { get; set; }
        public IFormFile? Foto { get; set; }

    }
}
