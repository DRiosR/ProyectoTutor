namespace Entidades.DTOs
{
    public class ContactoProfesorDTO
    {
        public int Id { get; set; }
        public int DocenteId { get; set; }
        public string TipoContacto { get; set; }
        public string Valor { get; set; }
    }

    public class ContactoProfesorCreateDTO
    {
        public int DocenteId { get; set; }
        public int TipoContactoId { get; set; }
        public string Valor { get; set; }
    }

    public class ContactoProfesorUpdateDTO : ContactoProfesorCreateDTO
    {
        public int Id { get; set; }
    }
} 