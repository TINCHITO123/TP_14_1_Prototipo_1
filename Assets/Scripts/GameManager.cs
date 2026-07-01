using UnityEngine;
using UnityEngine.SceneManagement; // Necesario para reiniciar la escena

public class GameManager : MonoBehaviour
{
    public UIManager uiManager;
    public TimerUiMannager timerUi; // Para mandarle el tiempo actual al texto
    
    public float timeRemaining = 60f;
    [HideInInspector] public bool juegoTerminado = false;

    void Start()
    {
        // Crucial: Asegura que el juego no inicie congelado al reiniciar
        Time.timeScale = 1f; 
    }

    void Update()
    {
        if (!juegoTerminado)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                timerUi.ActualizarTextoTimer(timeRemaining);
            }
            else
            {
                timeRemaining = 0;
                ActivarGameOver();
            }
        }
        else
        {
            // Si el juego terminó (por Win o Game Over) y presionas R, se reinicia
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }

    void ActivarGameOver()
    {
        juegoTerminado = true;
        uiManager.MostrarPantallaGameOver();
        Time.timeScale = 0f; // Congela el juego
    }

    // NUEVA FUNCIÓN: Llamá a esto cuando el jugador cumpla el objetivo en el aula
    public void ActivarWin()
    {
        juegoTerminado = true;
        uiManager.MostrarPantallaWin(); // Acordate de armar esta función en tu UIManager
        Time.timeScale = 0f; // Congela el juego al ganar
    }
}