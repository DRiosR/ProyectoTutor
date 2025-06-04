using System;

namespace Entidades.DTOs
{
    public class DocumentoDTO
    {
        public int Id { get; set; }
        public int DocenteId { get; set; }
        public string Titulo { get; set; }
        public string Tipo { get; set; }
        public string URL { get; set; }
        public DateTime FechaSubida { get; set; }
    }

    public class DocumentoCreateDTO
    {
        public int DocenteId { get; set; }
        public string Titulo { get; set; }
        public string Tipo { get; set; }
        public string URL { get; set; }
    }

    public class DocumentoUpdateDTO : DocumentoCreateDTO
    {
        public int Id { get; set; }
    }
} 