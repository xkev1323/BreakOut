using UnityEngine;

public class Bloque_Piedra : Bloque
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        resistencia = 5; // Resistencia del bloque de piedra
    }

    public override void RebotarBola()
    {
        base.RebotarBola();
        // Aqu� puedes agregar la l�gica espec�fica para el rebote del bloque de piedra
    }
}
