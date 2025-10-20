using UnityEngine;

public class Boss : MonoBehaviour
{
    public Transform firePoint;
    public GameObject fireballPrefab;
    public float shootInterval = 2f;
    public Transform target;

    private float timer;

    void Awake()
    {
        if (target == null && Camera.main != null)
            target = Camera.main.transform;
    }

    void Update()
    {
        if (target == null || firePoint == null) return;


        timer += Time.deltaTime;

 
        if (timer >= shootInterval)
        {
            Shoot();
            timer = 0f;
        }
    }

    void Shoot()
    {
 
        Vector3 direction = (target.position - firePoint.position).normalized;


        GameObject fireball = Instantiate(fireballPrefab, firePoint.position, Quaternion.LookRotation(direction));


        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(direction), 0.1f);
    }
}
