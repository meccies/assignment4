using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ScoreManagerTest : MonoBehaviour
{
    public TMP_Text currentScore;
    public AudioSource audioData;
    int score = 0;
    int maxScore = 6;

    void Start()
    {
        audioData = GetComponent<AudioSource>();
    }

    void AddScore(int amount)
    {
        if (score <= maxScore)
        {
            score += amount;
        }

        if (score >= maxScore)
        {
            SceneManager.LoadScene("WinScreen");

            Debug.Log("Max score reached");
        }

        currentScore.text = score.ToString();
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("WinColider"))
        {
            AddScore(1);
            audioData.Play();
        }
    }
}
// Note: Attach this script to the Paper ball prefab/GameObject! Make sure to select "Current Score" TMP for the counter
// For the sound effect, attach an Audio Source component to the Paper ball and attach the sound you imported in to said component