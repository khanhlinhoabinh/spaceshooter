using UnityEngine;
using UnityEngine.SceneManagement;


public class GameOverUI : MonoBehaviour
{
    public GameObject gameOverPanel;

    void Start()
    {
        gameOverPanel.SetActive(false);
    }

    public void ShowGameOver()
    {
        gameOverPanel.SetActive(true);
        Time.timeScale = 0f;
    }
    public void BackToMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }

}
