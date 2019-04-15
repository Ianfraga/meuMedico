using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace meumedico.Models
{
    [MetadataType(typeof(UsuarioMetadados))]

    public partial class Usuario
    {
    }

    public class UsuarioMetadados
    {
        [Required(ErrorMessage = "Obrigatório Informar ID do Usuário!")]
        public int IDEspec { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o nome do usuário!")]
        [StringLength(3, ErrorMessage = "O campo deve possuir no mínimo 3 caracteres!")]
        public string NomeUsuario { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o usuário!")]
        [StringLength(2, ErrorMessage = "O campo deve possuir no mínimo 2 caracteres!")]
        public string Usuario { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar Senha!")]
        //[StringLength(2, ErrorMessage = "O campo deve possuir no mínimo 2 caracteres!")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar Email!")]
        [StringLength(5, ErrorMessage = "O campo deve possuir no mínimo 5 caracteres!")]
        public string Email { get; set; }
    }
}