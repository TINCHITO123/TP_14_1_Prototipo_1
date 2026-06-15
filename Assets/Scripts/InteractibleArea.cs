using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractibleArea : MonoBehaviour
{
    public ScoreUiManager ScoreUi;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coleccionable"))
        {
            Destroy(other.gameObject);
            ScoreUi.AddPointAndUpdateScore();
        }
    }
}