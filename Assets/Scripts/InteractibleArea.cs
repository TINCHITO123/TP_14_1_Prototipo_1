using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractibleArea : MonoBehaviour
{
    public ScoreUiManager ScoreUi;
    public UIManager uiManager;       // Nueva referencia
    public GameManager gameManager;   // Nueva referencia

    public int puntajeMaximo = 5;     // Cantidad de coleccionables para ganar (ajústalo a tu gusto)

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coleccionable"))
        {
            Destroy(other.gameObject);
            ScoreUi.AddPointAndUpdateScore();

            // Lógica de condición de victoria integrada
            if (ScoreUi.score >= puntajeMaximo)
            {
                uiManager.MostrarPantallaWin();
                Time.timeScale = 0f;               // Congela el juego por completo
                gameManager.juegoTerminado = true; // Permite al GameManager habilitar el reinicio con 'R'
            }
        }
    }
}