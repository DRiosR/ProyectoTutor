namespace Entidades.DTOs
{
    public class EstadoCivilDTO
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
    }

    public class EstadoCivilCreateDTO
    {
        public string Descripcion { get; set; }
    }

    public class EstadoCivilUpdateDTO : EstadoCivilCreateDTO
    {
        public int Id { get; set; }
    }
} 