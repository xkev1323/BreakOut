using System;
using UnityEngine;
using UnityEngine.Events;

public class MuestraEventos : MonoBehaviour
{
    public UnityEvent MiEventoUnity; // UnityEvent para eventos personalizados
    public event EventHandler EnCasoDeEspacioPresionado; //OnSpacePressed event

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        EnCasoDeEspacioPresionado += EventoEscuchado; // Subscribe to the event
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Si se presiona la tecla Espacio, invocar el evento
            EnCasoDeEspacioPresionado?.Invoke(this, EventArgs.Empty);
            MiEventoUnity?.Invoke(); // Invocar el UnityEvent si hay suscriptores
        }
    }

    public void EventoEscuchado(object sender, EventArgs e)
    {
        // Este método se llamará cuando se dispare el evento EnCasoDeEspacioPresionado
        Debug.Log("¡Se ha presionado la tecla Espacio!");
    }

    public void EventoUnityDisparado()
    {
        Debug.Log("¡Evento Unity disparado!");
    }
}
