using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    public Text timeText;
    public GameObject endPanel;
    public Text finalTimeText;

    void Awake()
    {
        instance = this;
        endPanel.SetActive(false);
    }

    public void UpdateTime(float time)
    {
        int minutes = Mathf.FloorToInt(time / 60f);
        int seconds = Mathf.FloorToInt(time % 60f);
        int milliseconds = Mathf.FloorToInt((time * 100f) % 100f);
        timeText.text = string.Format("{0:00}:{1:00}.{2:00}", minutes, seconds, milliseconds);
    }

    public void ShowEndPanel(float finalTime)
    {
        endPanel.SetActive(true);
        int minutes = Mathf.FloorToInt(finalTime / 60f);
        int seconds = Mathf.FloorToInt(finalTime % 60f);
        int milliseconds = Mathf.FloorToInt((finalTime * 100f) % 100f);
        finalTimeText.text = "Tempo: " + string.Format("{0:00}:{1:00}.{2:00}", minutes, seconds, milliseconds);
    }
}