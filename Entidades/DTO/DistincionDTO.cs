using System;

namespace Entidades.DTOs
{
    public class DistincionDTO
    {
        public int Id { get; set; }
        public int DocenteId { get; set; }
        public string Titulo { get; set; }
        public string Institucion { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
    }

    public class DistincionCreateDTO
    {
        public int DocenteId { get; set; }
        public string Titulo { get; set; }
        public string Institucion { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
    }

    public class DistincionUpdateDTO : DistincionCreateDTO
    {
        public int Id { get; set; }
    }
} 