using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float torqueforce ;
    public Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddTorque(torqueforce);
        }
        else
        {
            rb.rotation = 0;
            //rb.angularVelocity = 0;
        }
    }
}
