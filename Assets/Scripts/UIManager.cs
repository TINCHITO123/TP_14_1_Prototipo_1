using UnityEngine;

public class UIManager : MonoBehaviour
{
    // Arrastra aquí tus contenedores/paneles del Canvas desde el Inspector
    public GameObject panelWin;
    public GameObject panelGameOver;

    public void MostrarPantallaWin()
    {
        panelWin.SetActive(true);
    }

    public void MostrarPantallaGameOver()
    {
        panelGameOver.SetActive(true);
    }
}