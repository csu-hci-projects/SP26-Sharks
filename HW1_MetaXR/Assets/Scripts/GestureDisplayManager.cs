using UnityEngine;
using TMPro;

public class GestureDisplayManager : MonoBehaviour
{
    public TextMeshProUGUI gestureText;

    public void ShowThumbsUp(string handName)
    {
        if (gestureText != null)
        {
            gestureText.text = "Thumbs Up detected, " + handName + " hand";
        }
    }

    public void ShowFist(string handName)
    {
        if (gestureText != null)
        {
            gestureText.text = "Fist detected, " + handName + " hand";
        }
    }

    public void ShowPeace(string handName)
    {
        if (gestureText != null)
        {
            gestureText.text = "Peace Sign detected, " + handName + " hand";
        }
    }

    public void ShowWaiting()
    {
        if (gestureText != null)
        {
            gestureText.text = "Waiting for gesture...";
        }
    }
}