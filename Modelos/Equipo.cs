﻿namespace FutbolDesktop.Modelos
{
    public class Equipo
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Estadio { get; set; } = string.Empty;

        public override string ToString()
        {
            return Nombre;
        }
    }
}
