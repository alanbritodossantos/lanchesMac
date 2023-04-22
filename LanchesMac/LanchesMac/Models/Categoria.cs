namespace LanchesMac.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string CategoriaName { get; set; }
        public string descricao { get; set; }

        public List<Lanche> lanches { get; set; }
    }
}
