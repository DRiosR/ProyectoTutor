using System;

namespace Entidades.DTOs
{
    public class TesisDirigidaDTO
    {
        public int Id { get; set; }
        public int DocenteId { get; set; }
        public string Titulo { get; set; }
        public string Estudiante { get; set; }
        public string Nivel { get; set; }
        public DateTime Fecha { get; set; }
        public string Institucion { get; set; }
    }

    public class TesisDirigidaCreateDTO
    {
        public int DocenteId { get; set; }
        public string Titulo { get; set; }
        public string Estudiante { get; set; }
        public string Nivel { get; set; }
        public DateTime Fecha { get; set; }
        public string Institucion { get; set; }
    }

    public class TesisDirigidaUpdateDTO : TesisDirigidaCreateDTO
    {
        public int Id { get; set; }
    }
} 