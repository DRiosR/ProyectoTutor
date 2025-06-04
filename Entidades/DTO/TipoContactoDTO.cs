namespace Entidades.DTOs
{
    public class TipoContactoDTO
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
    }

    public class TipoContactoCreateDTO
    {
        public string Descripcion { get; set; }
    }

    public class TipoContactoUpdateDTO : TipoContactoCreateDTO
    {
        public int Id { get; set; }
    }
} 