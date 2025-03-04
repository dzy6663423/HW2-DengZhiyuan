using UnityEngine;

public class Speedchange : MonoBehaviour
{
    private Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // This method is called when the collider enters a trigger collider
    void OnTriggerEnter2D(Collider2D other)
    {
            Rigidbody2D rb = other.GetComponent<Rigidbody2D>();

            rb.linearVelocity = -rb.linearVelocity;
        
    }
}
