namespace MVC_2024.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string CategoriaName { get; set; }

        public string CategoriaDescription { get; set; }

        public List<Cars> Car { get; set; }

    }
}
