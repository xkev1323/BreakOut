using UnityEngine;

public class Bloque_Largo : Bloque
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        resistencia = 4; // Resistencia del bloque largo
    }
    public override void RebotarBola()
    {
        base.RebotarBola();
        // Aquí puedes agregar la lógica específica para el rebote del bloque largo
    }
}
