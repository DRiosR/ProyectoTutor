namespace Entidades.DTOs
{
    public class SexoDTO
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
    }

    public class SexoCreateDTO
    {
        public string Descripcion { get; set; }
    }

    public class SexoUpdateDTO : SexoCreateDTO
    {
        public int Id { get; set; }
    }
} 