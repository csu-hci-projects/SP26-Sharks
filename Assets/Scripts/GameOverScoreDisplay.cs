using UnityEngine;
using UnityEngine.UI; 

public class GameOverScoreDisplay : MonoBehaviour
{
    private ScoreAbsorber scoreAbsorber;

    
    private Text scoreText;

    void Start()
    {
       
        scoreAbsorber = FindObjectOfType<ScoreAbsorber>();

        
        scoreText = GetComponent<Text>();

        
        if (scoreText == null)
        {
            Debug.LogError("GameOverScoreDisplay: No Text component found on this GameObject!");
        }
        if (scoreAbsorber == null)
        {
            Debug.LogError("GameOverScoreDisplay: No ScoreAbsorber found in the scene!");
        }
    }

    void Update()
    {
        if (scoreAbsorber != null && scoreText != null)
        {
            scoreText.text = "Score: " + scoreAbsorber.score;
        }
    }
}
