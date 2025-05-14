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
        // Aquí puedes agregar la lógica específica para el rebote del bloque alarga paddle
    }
    public override void AccionEspecial()
    {
        base.AccionEspecial();
        // Aquí puedes agregar la lógica específica para la acción especial del bloque alarga paddle
        // Por ejemplo, alargar el paddle
    }
}

