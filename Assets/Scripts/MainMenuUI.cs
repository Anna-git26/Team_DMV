using UnityEngine;
using UnityEngine.SceneManagement; // Fondamentale per cambiare scene

public class MainMenu : MonoBehaviour
{
    // Funzione per caricare la pista (la scena del gioco)
    public void PlayGame()
    {
        // "GameScene" deve essere il nome esatto della tua scena della pista
        SceneManager.LoadScene("GameScene");
    }

    // Funzione per chiudere il gioco
    public void QuitGame()
    {
        Debug.Log("Il gioco si sta chiudendo..."); // Utile per testare nell'editor
        Application.Quit();
    }
}