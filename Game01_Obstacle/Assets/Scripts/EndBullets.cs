using UnityEngine;

public class EndBullets : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            GameObject spawner = GameObject.FindGameObjectWithTag("Start");
            Destroy(spawner);
        }
    }
}
