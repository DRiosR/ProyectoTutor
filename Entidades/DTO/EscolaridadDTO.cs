using System;

namespace Entidades.DTOs
{
    public class EscolaridadDTO
    {
        public int Id { get; set; }
        public int DocenteId { get; set; }
        public string Nivel { get; set; }
        public string Institucion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
    }

    public class EscolaridadCreateDTO
    {
        public int DocenteId { get; set; }
        public string Nivel { get; set; }
        public string Institucion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
    }

    public class EscolaridadUpdateDTO : EscolaridadCreateDTO
    {
        public int Id { get; set; }
    }
} 