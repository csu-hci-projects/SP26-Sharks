using UnityEngine;

public class BlueBlockProximity : MonoBehaviour
{
    public Renderer targetRenderer;
    public Material normalMaterial;
    public Material proximityMaterial;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hand"))
        {
            if (targetRenderer != null && proximityMaterial != null)
            {
                targetRenderer.material = proximityMaterial;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Hand"))
        {
            if (targetRenderer != null && normalMaterial != null)
            {
                targetRenderer.material = normalMaterial;
            }
        }
    }
}