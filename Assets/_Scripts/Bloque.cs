using UnityEngine;

public class Bloque : MonoBehaviour
{
    public int resistencia = 1; // Resistencia del bloque

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (resistencia <= 0)
        {
            Destroy(this.gameObject); // Destruir el bloque si la resistencia es menor o igual a 0
        }
    }

    public virtual void RebotarBola()
    {

    }

    public virtual void AccionEspecial() //Acciones especiales que pueden largar el paddle, instanciar otra bola, etc.
    {

    }
}
