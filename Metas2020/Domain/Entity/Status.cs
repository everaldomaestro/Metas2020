using System.ComponentModel.DataAnnotations;

namespace Metas2020.Domain.Entity
{
    public enum Status
    {
        [Display(Name ="Não Iniciado")]
        NaoIniciado = 1,
        [Display(Name ="Em Andamento")]
        EmAndamento,
        [Display(Name ="Concluído")]
        Concluido,
        Cancelado
    }
}