using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProjetoGranado.Models
{
    public class Usuarios
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(60)]
        [Required]
        public string Nome { get; set; }

        [Key]
        [MaxLength(11)]
        public string Cpf { get; set; }

        [MaxLength(100)]
        public string Email { get; set; }

        [MaxLength(1)]
        public string Ativo { get; set; }

        [MaxLength(1)]
        public string Sexo { get; set; }

        [MaxLength(11)]
        public string Telefone { get; set; }

        [Required]
        public string Senha { get; set; }

        public List<Setor> Setor { get; set; }
        public List<GrupoUsuarios> GrupoUsuarios { get; set; }

        
    }
}
