using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonControler : MonoBehaviour
{
    public void LoadMainMenu()
    {
        SceneManager.LoadScene("Menu");
        
    }

    public void LoadEasy()
    {
        SceneManager.LoadScene("Easy");
    }

    public void LoadHard()
    {
        SceneManager.LoadScene("Hard");
    }

     public void MyQuit()
    {
        Application.Quit();
    }

     public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        //Debug.Log("Reset button - game restarted");
        
    }
}
