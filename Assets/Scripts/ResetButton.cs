using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetButton : MonoBehaviour
{

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        Debug.Log("Reset button - game restarted");
        
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}