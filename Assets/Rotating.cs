using UnityEngine;

public class Rotating : MonoBehaviour
{
    public Rigidbody2D rb;
        void Start()
    {
         rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddTorque(100);
    }
}
