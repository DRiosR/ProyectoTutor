using System;

namespace Entidades.DTOs
{
    public class PublicacionDTO
    {
        public int Id { get; set; }
        public int DocenteId { get; set; }
        public string Titulo { get; set; }
        public string Revista { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public string DOI { get; set; }
        public string URL { get; set; }
    }

    public class PublicacionCreateDTO
    {
        public int DocenteId { get; set; }
        public string Titulo { get; set; }
        public string Revista { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public string DOI { get; set; }
        public string URL { get; set; }
    }

    public class PublicacionUpdateDTO : PublicacionCreateDTO
    {
        public int Id { get; set; }
    }
} 