using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;                 
    public Vector3 offset = new Vector3(2f, 5f, -7f); 
    public float smoothTime = 0.2f;          
    private Vector3 velocity = Vector3.zero;

    [Header("Zoom Settings")]
    public float zoomSpeed = 5f;             
    public float minZoom = 4f;               
    public float maxZoom = 12f;              
    private float currentZoom = 1f;          

    void Start()
    {
        currentZoom = Mathf.Clamp(offset.magnitude, minZoom, maxZoom); 
    }

    void LateUpdate()
    {
        if (target == null || offset.magnitude < 0.01f) return;

        HandleZoom();

      
        Vector3 zoomedOffset = offset.normalized * currentZoom;

        
        Vector3 targetPosition = target.position + zoomedOffset;

        
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);

        
        transform.rotation = Quaternion.Euler(35f, 0f, 0f);
    }

    void HandleZoom()
    {
        
        float scroll = Input.GetAxis("Mouse ScrollWheel");

        if (Mathf.Abs(scroll) > 0.01f)
        {
           
            currentZoom -= scroll * zoomSpeed;
            currentZoom = Mathf.Clamp(currentZoom, minZoom, maxZoom);
        }
    }
}
