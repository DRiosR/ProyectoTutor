namespace Entidades.DTOs
{
    public class PRODEPDTO
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
    }

    public class PRODEPCreateDTO
    {
        public string Descripcion { get; set; }
    }

    public class PRODEPUpdateDTO : PRODEPCreateDTO
    {
        public int Id { get; set; }
    }
} 