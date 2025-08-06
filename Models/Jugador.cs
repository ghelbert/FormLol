namespace Tareas.Models;

public class Jugador
{
    [Required]
    public string? Nombre { get; set; }
    [Required]
    public string? Edad { get; set; }
    [Required]
    public string? FrecuenciaJuego { get; set; }
    [Required]
    public string? AñosJugando { get; set; }

}
