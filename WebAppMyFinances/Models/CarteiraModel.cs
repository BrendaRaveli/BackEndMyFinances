namespace WebAppMyFinances.Models
{
    public class CarteiraModel
    {
        public int Id { get; set; }
        public double Saldo { get; set; }
        public double Limite { get; set; }
        public DateTime DataDeCriacao { get; set; } = DateTime.Now.ToLocalTime();
        public DateTime DataDeAlteracao { get; set; } = DateTime.Now.ToLocalTime();
    }
}
