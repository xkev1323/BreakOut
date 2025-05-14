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
        // Aqu� puedes agregar la l�gica espec�fica para el rebote del bloque duplicador
    }

    public override void AccionEspecial()
    {
        base.AccionEspecial();
        // Aqu� puedes agregar la l�gica espec�fica para la acci�n especial del bloque duplicador
        // Por ejemplo, duplicar la bola
    }
}
