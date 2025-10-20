using UnityEngine;

public class BoundedRandomFly : MonoBehaviour
{
    public float speed = 5f;
    public float turnSpeed = 2f;
    public Vector3 areaCenter = Vector3.zero;
    public Vector3 areaSize = new Vector3(20, 10, 20);

    private Vector3 targetDirection;
    private float startY; 

    void Start()
    {
        transform.localRotation = Quaternion.Euler(0f, transform.localRotation.eulerAngles.y, 0f);

        startY = transform.position.y; 
        ChooseNewDirection();
    }

    void Update()
    {
        Vector3 pos = transform.position;
        pos.y = startY;
        transform.position = pos;

        Vector3 flatForward = transform.forward;
        flatForward.y = 0;
        flatForward.Normalize();

        Vector3 flatTarget = targetDirection;
        flatTarget.y = 0;
        flatTarget.Normalize();

        transform.forward = Vector3.Lerp(flatForward, flatTarget, Time.deltaTime * turnSpeed);

        transform.position += transform.forward * speed * Time.deltaTime;

        if (!IsInsideBounds(transform.position))
        {
            targetDirection = (areaCenter - transform.position).normalized;
            targetDirection.y = 0f;
        }

        if (Random.value < 0.01f)
            ChooseNewDirection();
    }


    bool IsInsideBounds(Vector3 pos)
    {
        Vector3 min = areaCenter - areaSize / 2;
        Vector3 max = areaCenter + areaSize / 2;
        return (pos.x > min.x && pos.x < max.x && pos.z > min.z && pos.z < max.z);
    }

    void ChooseNewDirection()
    {
        targetDirection = new Vector3(
            Random.Range(-1f, 1f),
            0f,
            Random.Range(-1f, 1f)
        ).normalized;
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.cyan;
        Gizmos.DrawWireCube(areaCenter, areaSize);
    }
}
