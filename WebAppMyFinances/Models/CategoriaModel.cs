namespace WebAppMyFinances.Models
{
    public class CategoriaModel
    {
        public int Id { get; set; }
        public string? NomeCategoriaPrincipal { get; set; }
        public string? NomeSubCategoria { get; set; }
        public bool CategoriaPrincipal { get; set; }
    }
}
