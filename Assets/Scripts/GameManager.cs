using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public bool isGameActive = false;
    public float raceTime = 0f;

    void Awake()
    {
        if (instance == null) instance = this;
        else Destroy(gameObject);
    }

    void Update()
    {
        if (isGameActive)
        {
            raceTime += Time.deltaTime;
            UIManager.instance.UpdateTime(raceTime);
        }
    }

    public void StartGame()
    {
        isGameActive = true;
        raceTime = 0f;
        Time.timeScale = 1f;
    }

    public void EndRace()
    {
        isGameActive = false;
        UIManager.instance.ShowEndPanel(raceTime);
        Time.timeScale = 0f; // Mette in pausa
    }

    public void RestartRace()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void BackToMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu"); // Nome della scena del menu
    }
}
