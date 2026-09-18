using UnityEngine;

public class StartBullets : MonoBehaviour
{
    [SerializeField] GameObject Bullet;
    [SerializeField] float timeToWait = 2f;
    [SerializeField] float timer = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.tag == "Start" && Time.time > timer)
        {
            Debug.Log("Bullets Fired");
            Vector3 position = new Vector3(Random.Range(-8.0f, 14.25f), 5.0f, 6.1f);
            Instantiate(Bullet, position, Quaternion.identity);
            Vector3 position2 = new Vector3(Random.Range(-8.0f, 14.25f), 5.0f, 6.1f);
            Instantiate(Bullet, position2, Quaternion.identity);
            Vector3 position3 = new Vector3(Random.Range(-8.0f, 14.25f), 5.0f, 6.1f);
            Instantiate(Bullet, position3, Quaternion.identity);
            timer = Time.time + timeToWait;
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            gameObject.tag = "Start";
            timer = Time.time + timeToWait;
            Debug.Log("Start Bullets");
        }
    }
}
