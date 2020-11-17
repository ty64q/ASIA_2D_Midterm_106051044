using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
   public void BackToMenu()
    {
        SceneManager.LoadScene("開始畫面");

    }

    public void Quit()
    {
        Application.Quit();
    }

}
