namespace Entidades.DTOs
{
    public class SNIDTO
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
    }

    public class SNICreateDTO
    {
        public string Descripcion { get; set; }
    }

    public class SNIUpdateDTO : SNICreateDTO
    {
        public int Id { get; set; }
    }
} 