using UnityEngine;
using UnityEngine.UI;
using System;

public class TimeRemainingDisplay : MonoBehaviour {
    Text text;
    LevelManager levelManager;

   
    void Start () {
        text = GetComponent<Text>();
        levelManager = FindObjectOfType<LevelManager>();
	}
	
	void Update () {
        text.text = "Time Remaining: " + Convert.ToInt32(levelManager.timeTillNextLevel);
	}
}
