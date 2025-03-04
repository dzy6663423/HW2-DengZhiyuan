using UnityEngine;

public class Lives : MonoBehaviour
{
    public GameObject ballPrefab;   // Assign your ball prefab in the Inspector
    public Vector2 spawnLocation;   // Set the desired spawn location in the Inspector
    public int maxBalls = 3;        // Number of balls allowed
    private int ballsSpawned = 0;

    public GameObject newBall;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ballsSpawned < maxBalls && newBall == null)
        {
            ballsSpawned++;
            Debug.Log("Spawning new ball. Balls spawned: " + ballsSpawned);
            GameObject newBall = Instantiate(ballPrefab, spawnLocation, Quaternion.identity);
            if (newBall != null)
            {
                CircleCollider2D collider = newBall.GetComponent<CircleCollider2D>();
            }
            if (GetComponent<Collider>() != null)
            {
                GetComponent<Collider>().enabled = true;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
       
        

        
    }
}
