using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject mainMenuPanel;
    public GameManager gameManager;

    // Metodo collegato al bottone "Play"
    public void OnPlayButtonPressed()
    {
        mainMenuPanel.SetActive(false); // Nasconde il menu
        gameManager.StartGame();        // Avvia il gioco
    }

    // Metodo collegato al bottone "Restart"
    public void OnRestartButtonPressed()
    {
        gameManager.RestartGame();
    }
}