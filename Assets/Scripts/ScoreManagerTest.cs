using UnityEngine;
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
            Time.timeScale = 0;
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

}
// Note: Attach this script to the Paper ball prefab/GameObject! Make sure to select "Current Score" TMP