using UnityEngine;

public class Speed : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public float speedBoost = 2f;

    void OnTriggerEnter2D(Collider2D other)
    {
        Rigidbody2D rb = other.GetComponent<Rigidbody2D>();
        if (rb != null && rb.linearVelocity.magnitude < 5f) // Assuming 5f is the certain value
        {
            rb.linearVelocity *= speedBoost;
        }
        Debug.Log("Speed boost applied to " + other.name);
        
    }
}
