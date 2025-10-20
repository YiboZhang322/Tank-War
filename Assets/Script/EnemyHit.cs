using UnityEngine;

public class EnemyHit : MonoBehaviour
{
    public GameObject explosionEffect; 
    public float destroyDelay = 0.2f;  

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Shell"))
        {

            if (explosionEffect != null)
            {
                Instantiate(explosionEffect, transform.position, Quaternion.identity);
            }

            Destroy(gameObject, destroyDelay);

            Destroy(collision.gameObject);
        }
    }
}
