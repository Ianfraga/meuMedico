using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace meumedico.Models
{
    [MetadataType(typeof(Paisesmetadados))]

    public partial class Pais { }

    public class Paisesmetadados
    {

        [Required(ErrorMessage = "Obrigatório Informar País!")]
        [StringLength(4, ErrorMessage = "O campo deve ser maior que 4 caracteres!")]
        public string Pais { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar Sigla")]
        [StringLength(2, ErrorMessage = "O campo deve ser menor que 2 caracteres!")]
        public string Sigla { get; set; }
    }
}