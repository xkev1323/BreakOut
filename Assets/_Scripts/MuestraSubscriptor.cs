using UnityEngine;

public class MuestraSubscriptor : MonoBehaviour
{
    MuestraEventos subscriptor;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        subscriptor = GetComponent<MuestraEventos>();
        subscriptor.EnCasoDeEspacioPresionado += MensajeEscuchadoPorElSubcriptor; // Suscribirse al evento
    }

    private void MensajeEscuchadoPorElSubcriptor(object sender, System.EventArgs e)
    {
        // Este método se llamará cuando se dispare el evento EnCasoDeEspacioPresionado
        Debug.Log("¡El subscriptor ha escuchado el evento de la tecla Espacio!");
        subscriptor.EnCasoDeEspacioPresionado -= MensajeEscuchadoPorElSubcriptor; // Desuscribirse del evento
    }
}
