using UnityEngine;
using UnityEngine.UI;

public class Shooting : MonoBehaviour
{
    public GameObject spherePrefab;
    public Transform firePoint;
    public GameObject Cylinder;
    public float speedM = 15f;
    public float speedR = 20.0f;
    public float projectileSpeed = 15f;  
    public int mainscore = 0;
    public int num = 10;
    public Text shelltext;
    public GameObject endGameBackground;

    void Start()
    {
        shelltext.text = "X " + num;
    }

    void Update()
    {
        Shoot();
        Move();
    }

    private void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (num > 0)
            {
                GameObject bullet = Instantiate(spherePrefab, firePoint.position, firePoint.rotation);

               
                Rigidbody rb = bullet.GetComponent<Rigidbody>();
                if (rb == null)
                    rb = bullet.AddComponent<Rigidbody>();

                rb.useGravity = true; 
                rb.mass = 1f;
                rb.linearDamping = 0f;

                
                Vector3 launchDir = firePoint.forward + Vector3.up * 0.3f;
                rb.linearVelocity = launchDir.normalized * projectileSpeed;

                num--;
            }
            else
            {
                endGameBackground.SetActive(true);
            }

            shelltext.text = "X " + num;
        }
    }

    private void Move()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(h, 0, 0) * Time.deltaTime * speedM);
        Cylinder.transform.Rotate(Vector3.forward, -v * Time.deltaTime * speedR, Space.Self);
    }
}
