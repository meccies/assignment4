using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartWinScreen : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene("MainLevel");

        Debug.Log("Play again button - game restarted");
        
    }
}
