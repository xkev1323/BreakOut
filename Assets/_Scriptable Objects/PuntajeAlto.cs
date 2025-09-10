using UnityEngine;

[CreateAssetMenu(fileName = "PuntajeAlto", menuName = "Herramientas/PuntajeAlto", order = 0)]
public class PuntajeAlto : PuntajePersistente
{
    public int puntaje = 0; // Variable to hold the high score
    public int puntajeAlto = 10000; // Variable to hold the high score threshold
}
