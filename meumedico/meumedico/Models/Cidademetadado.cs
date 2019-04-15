using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace meumedico.Models
{
    [MetadataType(typeof(Cidademetadado))]

    public partial class Cidade { }

    public class Cidademetadado
    {
        [Required(ErrorMessage = "Obrigatório Informar Cidade")]
        [StringLength(6, ErrorMessage = "O campo deve ser maior que 6 caracteres!")]
        public string Cidade { get; set; }

    }
}