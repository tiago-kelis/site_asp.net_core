namespace MVC_2024.Models
{
    public class Cars
    {
        public int CarsId { get; set; }
        public string CarsName { get; set; }
        public string CarsDescriptionLittle { get; set; }

        public string CarsDescriptionLong { get; set; }

       public string CarsPreco {  get; set; }

        public string CarsImageUrl { get; set; }

        public string CarsThambnailUrl { get; set; }

        public bool IsCarsPreference { get; set; }

        public bool CarsEmStoque { get; set; }

        public int CategoriaId { get; set; }

        public virtual Categoria Categoria { get; set; }    
    }
}
