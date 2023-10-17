using System.ComponentModel.DataAnnotations;
using WebAppMyFinances.Enums;

namespace WebAppMyFinances.Models
{
    public class ExempFuncionarioModel
    {
        [Key]
        public int Id { get; set; }
        public int Nome { get; set; }
        public int Sobrenome { get; set; }
        public ExempDepartamentoEnum Departamento { get; set; }
        public int Ativo { get; set; }
        public ExempTurnoEnum Turno { get; set; }
        public DateTime DataDeCriacao { get; set; } = DateTime.Now.ToLocalTime();
        public DateTime DataDeAlteracao { get; set; } = DateTime.Now.ToLocalTime();
    }
}
