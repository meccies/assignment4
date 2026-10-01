using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ScoreManagerTest : MonoBehaviour
{
    public TMP_Text currentScore;
    int score = 0;
    int maxScore = 6;

    void AddScore(int amount)
    {
        if (score <= maxScore)
        {
            score += amount;
        }

        if (score >= maxScore)
        {
            Restart();
            Debug.Log("Max score reached");
        }

        currentScore.text = score.ToString();
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("WinColider"))
        {
            AddScore(1);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
// Note: Attach this script to the Paper ball prefab/GameObject! Make sure to select "Current Score" TMP