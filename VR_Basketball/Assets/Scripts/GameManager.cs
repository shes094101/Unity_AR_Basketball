using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene("Main");
    }

    public void QuitGame() 
    {
        Application.Quit();
    }
}
