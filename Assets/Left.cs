using UnityEngine;

public class Left : MonoBehaviour
{
    public float leftForce = 2f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Rigidbody2D rb = other.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.AddForce(Vector2.left * leftForce, ForceMode2D.Impulse);
        }
    }
}
