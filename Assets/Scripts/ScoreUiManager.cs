using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreUiManager : MonoBehaviour
{
    public TextMeshProUGUI txtScore;
    public int score = 0;

    void Start()
    {
        txtScore.text = score.ToString();
    }

    public void AddPointAndUpdateScore()
    {
        score++;
        txtScore.text = score.ToString();
    }
}