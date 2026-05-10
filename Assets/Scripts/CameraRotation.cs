using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    [Header("Rotation Settings")]
    public float rotationSpeed = 5.0f;
    public Transform playerBody; // assign your player body (optional)

    private float xRotation = 0f;
    private Vector2 lastTouchPosition;
    private bool isDragging = false;

    void Start()
    {

#if UNITY_STANDALONE || UNITY_EDITOR
        Cursor.lockState = CursorLockMode.Locked;
#endif
    }

    void Update()
    {
#if UNITY_STANDALONE || UNITY_EDITOR
        HandleMouseInput();
#elif UNITY_ANDROID || UNITY_IOS
        HandleTouchInput();
#endif
    }


    void HandleMouseInput()
    {
        float mouseX = Input.GetAxis("Mouse X") * rotationSpeed;
        float mouseY = Input.GetAxis("Mouse Y") * rotationSpeed;

        RotateCamera(mouseX, mouseY);
    }

    void HandleTouchInput()
    {
        if (Input.touchCount == 1)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                lastTouchPosition = touch.position;
                isDragging = true;
            }
            else if (touch.phase == TouchPhase.Moved && isDragging)
            {
                Vector2 delta = touch.deltaPosition;
                float touchX = delta.x * rotationSpeed * 0.02f;
                float touchY = delta.y * rotationSpeed * 0.02f;

                RotateCamera(touchX, touchY);
            }
            else if (touch.phase == TouchPhase.Ended || touch.phase == TouchPhase.Canceled)
            {
                isDragging = false;
            }
        }
    }

  
    void RotateCamera(float inputX, float inputY)
    {
        
        if (playerBody != null)
            playerBody.Rotate(Vector3.up * inputX);
        else
            transform.Rotate(Vector3.up * inputX);


        xRotation -= inputY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        Camera cam = GetComponentInChildren<Camera>();
        if (cam != null)
        {
            cam.transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        }
    }
}
