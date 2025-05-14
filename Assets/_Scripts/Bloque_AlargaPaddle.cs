using UnityEngine;

public class Bloque_AlargaPaddle : Bloque
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        resistencia = 2; // Resistencia del bloque alarga paddle (El bloque no se destruye)
    }
    public override void RebotarBola()
    {
        base.RebotarBola();
        // Aqu� puedes agregar la l�gica espec�fica para el rebote del bloque alarga paddle
    }
    public override void AccionEspecial()
    {
        base.AccionEspecial();
        // Aqu� puedes agregar la l�gica espec�fica para la acci�n especial del bloque alarga paddle
        // Por ejemplo, alargar el paddle
    }
}

