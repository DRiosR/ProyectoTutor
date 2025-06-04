using System;

namespace Entidades.DTOs
{
    public class EducacionDTO
    {
        public int Id { get; set; }
        public int DocenteId { get; set; }
        public string Titulo { get; set; }
        public string Institucion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Descripcion { get; set; }
    }

    public class EducacionCreateDTO
    {
        public int DocenteId { get; set; }
        public string Titulo { get; set; }
        public string Institucion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Descripcion { get; set; }
    }

    public class EducacionUpdateDTO : EducacionCreateDTO
    {
        public int Id { get; set; }
    }
} 