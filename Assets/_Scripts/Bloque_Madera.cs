using UnityEngine;

public class Bloque_Madera : Bloque
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        resistencia = 3; // Resistencia del bloque de madera
    }

    public override void RebotarBola()
    {
        base.RebotarBola();
    }
}
