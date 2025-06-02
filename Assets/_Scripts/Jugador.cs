using UnityEngine;
using UnityEngine.InputSystem;

public class Jugador : MonoBehaviour
{
    public int limiteX = 23; // Límite en el eje X para el jugador
    public float velocidadPaddle = 45f; // Velocidad de movimiento del jugador


    Vector3 mousePos2D;
    Vector3 mousePos3D;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //mousePos2D = Input.mousePosition; //Input Manager Legacy

        float movimientoTeclado = 0f; // Inicializar el movimiento del teclado en 0

        // Controlar con el teclado y Control de xbox o PS4
        transform.Translate(Input.GetAxis("Horizontal") * Vector3.down * velocidadPaddle * Time.deltaTime); // Mover el jugador en el eje X según la entrada horizontal (Input Manager Legacy) (Controlar con un control de Xbox o PS4)

        Vector3 pos = this.transform.position; // Obtener la posición actual del jugador

        // Controlar con las flechas del teclado con el nuevo Input System (comentado porque ya se controla con el Input Manager Legacy)
        //if (Keyboard.current.leftArrowKey.isPressed) // Si se presiona la flecha izquierda
        //{
        //    //transform.Translate(Vector3.up * velocidadPaddle * Time.deltaTime); // Mover a la izquierda
        //    movimientoTeclado = -1f; // Asignar un valor negativo para mover a la izquierda
        //}
        //else if (Keyboard.current.rightArrowKey.isPressed) // Si se presiona la flecha derecha
        //{
        //    //transform.Translate(Vector3.down * velocidadPaddle * Time.deltaTime); // Mover a la derecha
        //    movimientoTeclado = 1f; // Asignar un valor positivo para mover a la derecha
        //}

        //if (movimientoTeclado != 0f)
        //{
        //    //pos.x += movimientoTeclado * velocidadPaddle * Time.deltaTime; // Actualizar la posición X del jugador según el movimiento del teclado
        //}

        // Controlar con el mouse
        if (movimientoTeclado == 0f && Input.GetAxis("Horizontal") == 0)
        {
            // Usar el nuevo Input System para obtener la posición del mouse
            mousePos2D = Mouse.current.position.ReadValue(); // Obtener la posición del mouse en 2D
            mousePos2D.z = -Camera.main.transform.position.z; // Asignar la posición Z de la cámara para convertir a 3D
            mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D); // Convertir la posición 2D del mouse a 3D
            pos.x = mousePos3D.x; // Actualizar la posición X del jugador con la posición X del mouse
        }

        // Limitar la posición del jugador dentro de los límites establecidos
        if (pos.x < -limiteX) pos.x = -limiteX; // Limitar la posición X a la izquierda
        else if (pos.x > limiteX) pos.x = limiteX; // Limitar la posición X a la derecha
        this.transform.position = pos; // Asignar la nueva posición al jugador
    }
}
