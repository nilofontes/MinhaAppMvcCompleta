using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace RunIO.App.ViewModels
{
    public class EnderecoViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo {0} deve ser preenchido")]
        [StringLength(200, ErrorMessage = "O campo {0} deve ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "O campo {0} deve ser preenchido")]
        [StringLength(50, ErrorMessage = "O campo {0} deve ter entre {2} e {1} caracteres", MinimumLength = 1)]
        public string Numero { get; set; }

        public string Complemento { get; set; }
        [Required(ErrorMessage = "O campo {0} deve ser preenchido")]
        [StringLength(8, ErrorMessage = "O campo {0} deve ter entre {1} caracteres", MinimumLength = 8)]

        public string Cep { get; set; }
        [Required(ErrorMessage = "O campo {0} deve ser preenchido")]
        [StringLength(100, ErrorMessage = "O campo {0} deve ter entre {2} e {1} caracteres", MinimumLength = 2)]

        public string Bairro { get; set; }
        [Required(ErrorMessage = "O campo {0} deve ser preenchido")]
        [StringLength(100, ErrorMessage = "O campo {0} deve ter entre {2} e {1} caracteres", MinimumLength = 2)]

        public string Cidade { get; set; }
        [Required(ErrorMessage = "O campo {0} deve ser preenchido")]
        [StringLength(2, ErrorMessage = "O campo {0} deve ter entre {1} caracteres", MinimumLength = 2)]

        public string Estado { get; set; }

        /* EF Relation */
        [HiddenInput]
        public Guid FornecedorId { get; set; }
    }
}
