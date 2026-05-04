using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool isGameActive = false;

    void Start()
    {
        // All'inizio il gioco è fermo finché non premiamo "Start" nel menu
        Time.timeScale = 0;
    }

    public void StartGame()
    {
        isGameActive = true;
        Time.timeScale = 1; // Fa ripartire il tempo
        Debug.Log("Gara Iniziata!");
    }

    public void RestartGame()
    {
        // Ricarica la scena attuale
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}