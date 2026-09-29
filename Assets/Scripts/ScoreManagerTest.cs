using UnityEngine;
using TMPro;

public class ScoreManagerTest : MonoBehaviour
{
    public TMP_Text currentScore;
    int score = 0;

    void AddScore(int amount)
    {
        score += amount;
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