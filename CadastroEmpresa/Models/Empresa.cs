using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroEmpresa.Models
{

    // Criação dos atributos e Nomeação das tabelas e campos do Banco de dados.
    [Table("Empresa")]
    public class Empresa
    {
        [Display(Name = "Id")]
        [Column("Id")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Nome Fantasia")]
        [Column("Nome Fantasia")]
        public string Nome_Fantasia { get; set; }

        [Required]
        [Display(Name = "Cnpj")]
        [Column("Cnpj")]
        public int Cnpj { get; set; }

        [Required]
        [Display(Name = "Telefone")]
        [Column("Telefone")]
        public int Telefone { get; set; }

        [EmailAddress]
        [Display(Name = "Email")]
        [Column("Email")]
        public string Email { get; set; }

        [Display(Name = "Data de Cadastro")]
        [DataType(DataType.Date)]
        [Column("Data de Cadastro")]
        public string Data_Cadastro { get; set; }

    }
  
}
