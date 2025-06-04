using System;

namespace Entidades.DTOs
{
    public class ProyectoDTO
    {
        public int Id { get; set; }
        public int DocenteId { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Institucion { get; set; }
        public string Rol { get; set; }
    }

    public class ProyectoCreateDTO
    {
        public int DocenteId { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Institucion { get; set; }
        public string Rol { get; set; }
    }

    public class ProyectoUpdateDTO : ProyectoCreateDTO
    {
        public int Id { get; set; }
    }
} 