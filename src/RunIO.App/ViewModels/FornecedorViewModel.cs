﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RunIO.App.ViewModels
{
    public class FornecedorViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo {0} deve ser preenchido")]
        [StringLength(100, ErrorMessage = "O campo {0} deve ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} deve ser preenchido")]
        [StringLength(14, ErrorMessage = "O campo {0} deve ter entre {2} e {1} caracteres", MinimumLength = 11)]
        public string Documento { get; set; }

        [DisplayName("Tipo")]
        public int TipoFornecedor { get; set; }

        public EnderecoViewModel Endereco { get; set; }

        [DisplayName("Ativo?")]
        public bool Ativo { get; set; }

        /* EF Relation */
        public IEnumerable<ProdutoViewModel> Produtos { get; set; }
    }
}
