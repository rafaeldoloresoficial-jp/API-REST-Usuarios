
using System;

namespace API_REST.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Correo { get; set; } = null!;
        public DateTime FechaDeNacimiento { get; set; }
    }
}