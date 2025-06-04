namespace Entidades.DTOs
{
    public class NombramientoDTO
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
    }

    public class NombramientoCreateDTO
    {
        public string Descripcion { get; set; }
    }

    public class NombramientoUpdateDTO : NombramientoCreateDTO
    {
        public int Id { get; set; }
    }
} 