using Recursos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Anotaciones.ViewModel
{
    public class ModelUsuario
    {
        public int Id { get; set; }
        //[Required(ErrorMessage ="campo obligatorio")]
        [Required(ErrorMessageResourceType =typeof(Cadena),ErrorMessageResourceName =  "error1")]
        [StringLength(10,ErrorMessage ="maximo 10 caracteres")]
        [Display(ResourceType = typeof(Cadena), Name = "valor1")]
        public string Username { get; set; }
        public string Pasword { get; set; }
        
        public string Nombre { get; set; }
        [Display(Name = "Apellido")]

        [RegularExpression("^[a-zA-Z]+$",ErrorMessage ="solo letras")]
        public string Apellido { get; set; }
        [Required]
        public string Telefono { get; set; }
        [EmailAddress]
        public string Correo { get; set; }
        
        public int Idperfilcab { get; set; }

    }
}