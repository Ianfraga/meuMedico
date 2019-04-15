using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace meumedico.Models
{
    [MetadataType(typeof(Medicometadados))]

    public partial class Medicos
    {
    }

    public class Medicometadados
    { 

        [Required(ErrorMessage ="Obrigatório Informar CRM!")]
        [StringLength(30, ErrorMessage = "O CRM deve possuir 30 caracteres!")]
        public string CRM { get; set; }

        [Required(ErrorMessage ="Obrigatório Informar Nome!")]
        [StringLength(10, ErrorMessage = "O Nome deve ser maior que 10 caracteres!")]
        public string Nome { get; set; }

        [Required(ErrorMessage ="Obrigatório Informar o Endereço")]
        [StringLength(10,ErrorMessage ="O Endereço deve ser maior que 10 caracteres!")]   
        public string Endereco { get; set; }

        [Required(ErrorMessage ="Obrigatório Informar o Bairro")]
        [StringLength(10,ErrorMessage ="Bairro deve ser maior que 10 caracteres!")]   
        public string Bairro { get; set; }

        [Required(ErrorMessage ="Obrigatório Informar o Email")]
        [StringLength(10,ErrorMessage ="Email deve ser maior que 10 caracteres!")]   
        public string Email { get; set; }

        [Required(ErrorMessage ="Obrigatório Informar Atendimento por Convenio!")] 
        public bool AtendConv { get; set; }

        [Required(ErrorMessage ="Obrigatório Informar se possuí clínica!")] 
        public bool Clinica { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar se possui ou não Website")]
        [StringLength(8, ErrorMessage ="Campo deve conter mais do que 8 caracteres")]
        public String Web { get; set; }
    }

}