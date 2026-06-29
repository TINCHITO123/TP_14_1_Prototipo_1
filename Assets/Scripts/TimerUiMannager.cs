using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerUiMannager : MonoBehaviour
{
    public TextMeshProUGUI txtTimer;

    // El tiempo ahora es controlado por el GameManager. 
    // Este método recibe los datos y actualiza el texto en pantalla.
    public void ActualizarTextoTimer(float timeRemaining)
    {
        int seconds = Mathf.CeilToInt(timeRemaining);
        txtTimer.text = "00:" + seconds.ToString("00");
    }
}