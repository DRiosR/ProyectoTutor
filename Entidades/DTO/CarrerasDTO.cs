namespace Entidades.DTOs
{
    public class CarrerasDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    }

    public class CarrerasCreateDTO
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    }

    public class CarrerasUpdateDTO : CarrerasCreateDTO
    {
        public int Id { get; set; }
    }
} 