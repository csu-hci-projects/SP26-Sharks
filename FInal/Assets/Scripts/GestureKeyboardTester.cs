using UnityEngine;

public class GestureKeyboardTester : MonoBehaviour
{
    public GestureDisplayManager gestureDisplayManager;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            gestureDisplayManager.ShowThumbsUp("Right");
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            gestureDisplayManager.ShowFist("Left");
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            gestureDisplayManager.ShowPeace("Right");
        }

        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            gestureDisplayManager.ShowWaiting();
        }
    }
}