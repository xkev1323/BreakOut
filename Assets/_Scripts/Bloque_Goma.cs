using UnityEngine;

public class Bloque_Goma : Bloque
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        resistencia = 1; // Resistencia del bloque de goma (El bloque no se destruye)
    }

    public override void RebotarBola()
    {
        base.RebotarBola();
        // Aquí puedes agregar la lógica específica para el rebote del bloque de goma (Rebotar Rapido la bola)
    }
}
