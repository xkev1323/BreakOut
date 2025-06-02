using UnityEngine;
using UnityEngine.InputSystem;

public class Bola : MonoBehaviour
{
    public bool isGameStarted = false; // Indica si el juego ha comenzado
    public float velocidadBola = 25f; // Velocidad de la bola

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Posicionar la bola en el centro de la pantalla del paddle
        Vector3 posicionInicial = GameObject.FindGameObjectWithTag("Jugador").transform.position;
        posicionInicial.y += 3; // Ajustar la posición Y para que esté encima del paddle
        this.transform.position = posicionInicial; // Asignar la posición inicial a la bola
        this.transform.SetParent(GameObject.FindGameObjectWithTag("Jugador").transform); // Hacer que la bola sea hija del jugador
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.isPressed || Input.GetButton("Submit"))
        {
            isGameStarted = true; // Cambiar el estado del juego a iniciado
            this.transform.SetParent(null); // Desvincular la bola del jugador
            GetComponent<Rigidbody>().linearVelocity = velocidadBola * Vector3.up; // Aplicar una velocidad inicial hacia arriba
        }
    }
}
