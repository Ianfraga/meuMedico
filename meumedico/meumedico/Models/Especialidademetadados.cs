using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace meumedico.Models
{
    [MetadataType(typeof(Especialidademetadados))]

    public partial class Especialidade
    {
    }

    public class Especialidademetadados
    {
        [Required(ErrorMessage = "Obrigatório Informar ID da Especialidade!")]
        public int IDEspec { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o nome da Especialidade!")]
        [StringLength(10, ErrorMessage = "O campo deve possuir no mínimo 10 caracteres!")]
        public string Especialidade { get; set; }
    }
}