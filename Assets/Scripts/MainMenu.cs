using UnityEngine;
using UnityEngine.SceneManagement; // Necessario per cambiare scena

public class MainMenu : MonoBehaviour
{
    // Funzione da collegare al bottone "Start game"
    public void PlayGame()
    {
        // Sostituisci "NomeDellaTuaScenaDiGioco" con il nome reale della scena in cui si corre
        SceneManager.LoadScene("adem");
    }

    // Funzione da collegare al bottone "Exit"
    public void QuitGame()
    {
        Debug.Log("Uscita dal gioco..."); // Utile per vedere se funziona nell'Editor
        Application.Quit();
    }
}
