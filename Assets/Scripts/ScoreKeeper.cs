using UnityEngine;
using System.Collections;

public class ScoreKeeper : MonoBehaviour
{
    public int score = 0;

    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    void Update()
    {
    }

    public void IncrementScore(int amount)
    {
        score += amount;
        AudioSource source = GetComponent<AudioSource>();
        source.Play();
    }
}
