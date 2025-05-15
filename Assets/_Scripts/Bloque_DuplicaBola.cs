using UnityEngine;

public class Bloque_DuplicaBola : Bloque
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        resistencia = 2; // Resistencia del bloque duplicador (El bloque no se destruye)
    }
    public override void RebotarBola()
    {
        base.RebotarBola();
        // Aquí puedes agregar la lógica específica para el rebote del bloque duplicador
    }

    public override void AccionEspecial()
    {
        base.AccionEspecial();
        // Aquí puedes agregar la lógica específica para la acción especial del bloque duplicador
        // Por ejemplo, duplicar la bola
    }
}
