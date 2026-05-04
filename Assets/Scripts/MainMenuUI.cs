using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuUI : MonoBehaviour
{
    public string gameSceneName = "GameScene"; // Nome della scena di gioco

    public void PlayButton()
    {
        SceneManager.LoadScene(gameSceneName);
    }

    public void QuitButton()
    {
        Debug.Log("Esco dal gioco"); // Funziona solo nella build
        Application.Quit();
    }
}
