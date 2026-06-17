using UnityEngine;
using TMPro;

public class ScoreUiManager : MonoBehaviour
{
    public TextMeshProUGUI txtScore;
    public int score = 0;

    void Start()
    {
        txtScore.text = "Score: " + score;
    }

    public void AddPointAndUpdateScore()
    {
        score++;
        txtScore.text = "Score: " + score;
    }
}