using UnityEngine;

public class PurpleBlockDisappear : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hand"))
        {
            gameObject.SetActive(false);
        }
    }
}