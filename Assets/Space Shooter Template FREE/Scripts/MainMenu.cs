using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        Time.timeScale = 1f;   // đảm bảo game không bị pause khi load lại
        SceneManager.LoadScene("BattleScene");
    }

    public void QuitGame()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }
}
