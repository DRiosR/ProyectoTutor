namespace Entidades.DTOs
{
    public class CategoriasDTO
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
    }

    public class CategoriasCreateDTO
    {
        public string Descripcion { get; set; }
    }

    public class CategoriasUpdateDTO : CategoriasCreateDTO
    {
        public int Id { get; set; }
    }
} 