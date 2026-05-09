using UnityEngine;

public class XRITGesturePlaceholder : MonoBehaviour
{
    public GestureDisplayManager gestureDisplayManager;

    public void DetectThumbsUpLeft()
    {
        if (gestureDisplayManager != null)
        {
            gestureDisplayManager.ShowThumbsUp("Left");
        }
    }

    public void DetectThumbsUpRight()
    {
        if (gestureDisplayManager != null)
        {
            gestureDisplayManager.ShowThumbsUp("Right");
        }
    }

    public void DetectFistLeft()
    {
        if (gestureDisplayManager != null)
        {
            gestureDisplayManager.ShowFist("Left");
        }
    }

    public void DetectFistRight()
    {
        if (gestureDisplayManager != null)
        {
            gestureDisplayManager.ShowFist("Right");
        }
    }

    public void DetectPeaceLeft()
    {
        if (gestureDisplayManager != null)
        {
            gestureDisplayManager.ShowPeace("Left");
        }
    }

    public void DetectPeaceRight()
    {
        if (gestureDisplayManager != null)
        {
            gestureDisplayManager.ShowPeace("Right");
        }
    }

    public void ResetGesture()
    {
        if (gestureDisplayManager != null)
        {
            gestureDisplayManager.ShowWaiting();
        }
    }
}