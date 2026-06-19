using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerUiMannager : MonoBehaviour
{
    public TextMeshProUGUI txtTimer;

    float timeRemaining = 60f;

    void Start()
    {
    }

    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;

            int seconds = Mathf.CeilToInt(timeRemaining);

            txtTimer.text = "00:" + seconds.ToString("00");
        }
    }
}