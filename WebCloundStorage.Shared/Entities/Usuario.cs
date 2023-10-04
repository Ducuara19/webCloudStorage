using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCloundStorage.Shared.Entities
{
    public class Usuario
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="El nombre o usuario es requerido")]
        public string UserName { get; set; } = null;

        [Required(ErrorMessage = "La contraseña es requerida")]
        public string Password { get; set; } = null;
    }
}
