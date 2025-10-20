using UnityEngine;

public class Sphere : MonoBehaviour
{
    public Rigidbody rb;
    public Vector3 force;
    public float speed = 100f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        force = transform.up * speed;
        rb.AddForce(force);
        Destroy(gameObject, 20f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}