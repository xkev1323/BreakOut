using UnityEngine;
using TMPro; // Importing TextMeshPro namespace for text display

public class Puntaje : MonoBehaviour
{
    public Transform transformPuntajeAlto; // Transform to position the score text
    public Transform transformPuntajeActual; // Transform to position the current score text
    public TMP_Text textoPuntajeAlto; // TextMeshPro text for high score
    public TMP_Text textoActual; // TextMeshPro text for current score
    public PuntajeAlto puntajeAltoSO; // ScriptableObject to hold high score data
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transformPuntajeActual = GameObject.Find("PuntajeActual").transform; // Find the Transform for current score
        transformPuntajeAlto = GameObject.Find("PuntajeAlto").transform; // Find the Transform for high score
        textoActual = transformPuntajeActual.GetComponent<TMP_Text>(); // Get the TextMeshPro component for current score
        textoPuntajeAlto = transformPuntajeAlto.GetComponent<TMP_Text>(); // Get the TextMeshPro component for high score

        //if (PlayerPrefs.HasKey("PuntajeAlto"))
        //{
        //    //puntajeAlto = PlayerPrefs.GetInt("PuntajeAlto"); // Load high score from PlayerPrefs if it exists
        //    textoPuntajeAlto.text = $"PuntajeAlto: {puntajeAltoSO.puntajeAlto}"; // Update high score text
        //}

        puntajeAltoSO.Cargar(); // Load high score data from ScriptableObject
        textoPuntajeAlto.text = $"PuntajeAlto: {puntajeAltoSO.puntajeAlto}"; // Update high score text
        puntajeAltoSO.puntaje = 0; // Initialize current score to 0
    }

    private void FixedUpdate()
    {
        puntajeAltoSO.puntaje += 50; // Increment the current score by 50 every FixedUpdate call
    }

    // Update is called once per frame
    void Update()
    {
        textoActual.text = $"PuntajeActual: {puntajeAltoSO.puntaje}";
        if (puntajeAltoSO.puntaje > puntajeAltoSO.puntajeAlto)
        {
            puntajeAltoSO.puntajeAlto = puntajeAltoSO.puntaje; // Update high score if current score exceeds it
            textoPuntajeAlto.text = $"PuntajeAlto: {puntajeAltoSO.puntajeAlto}"; // Update high score text
            puntajeAltoSO.Guardar(); // Save the updated high score to ScriptableObject
            //PlayerPrefs.SetInt("PuntajeAlto", puntajeAltoSO.puntajeAlto); // Save the new high score to PlayerPrefs
        }
    }
}
