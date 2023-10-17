namespace WebAppMyFinances.Models
{
    public class ServiceResponse<T>
    {
        public T? Dados { get; set; }
        public string Mensagens { get; set; } = string.Empty;
        public bool Sucesso { get; set; } = true;
    }
}
