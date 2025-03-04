using UnityEngine;

public class punch : MonoBehaviour
{
    public float punchDistance = 4f;
    public float punchSpeed = 30f;
    public float returnSpeed = 2f;

    private Vector3 startPos;
    private float punchDuration;
    private float returnDuration;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos = transform.position;
        punchDuration = punchDistance / punchSpeed;
        returnDuration = punchDistance / returnSpeed;
    }

    void Update()
    {
        float cycleTime = punchDuration + returnDuration;
        float tInCycle = Time.time % cycleTime;

        if (tInCycle < punchDuration)
        {
            float fraction = tInCycle / punchDuration;
            transform.position = Vector3.Lerp(
                startPos, 
                startPos + Vector3.right * punchDistance, 
                fraction
            );
        }
        else
        {
            float fraction = (tInCycle - punchDuration) / returnDuration;
            transform.position = Vector3.Lerp(
                startPos + Vector3.right * punchDistance, 
                startPos, 
                fraction
            );
        }
    }
}
