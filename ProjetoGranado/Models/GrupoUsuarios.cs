using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProjetoGranado.Models
{
    public class GrupoUsuarios
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(60)]
        [Required]
        public string Nome { get; set; }
    }
}
