using UnityEngine;

public class HitScore : MonoBehaviour
{
    public int score = 100;
    private GameObject player;

    private void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Shell")
        {
            player.GetComponent<Shooting>().mainscore += score;
        }
    }
}
