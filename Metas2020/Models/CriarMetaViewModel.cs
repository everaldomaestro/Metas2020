using Metas2020.Domain.Entity;
using System;
using System.ComponentModel.DataAnnotations;

namespace Metas2020.Models
{
    public class CriarMetaViewModel
    {
        public int MetaId { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Data de início")]
        public DateTime DataInicio { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Quem?")]
        public int UsuarioId { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Área")]
        public int AreaId { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Utiliza recurso financeiro?")]
        public bool UsaRecursoFinanceiro { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Status")]
        public Status Status { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Motivação")]
        public string Motivacao { get; set; }
    }
}
