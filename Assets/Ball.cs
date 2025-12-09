using UnityEngine;

public class Ball : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Vector2 startPos;
    public Rigidbody2D rb;
    public float startS;
    void Start()
    {
        LaunchBall();
        //Reset Position
        startPos = transform.position;
        rb = GetComponent<Rigidbody2D>();
    }

    void LaunchBall()
    {
        //Moving ball 
        bool isRight = UnityEngine.Random.value >= 0.5;
        float xVelocity = -1f;
        if (isRight == true)
        {
            xVelocity = 1f;
        }
        float yVelocity = UnityEngine.Random.Range(-1f, 1f);
        rb.linearVelocity = new Vector2(xVelocity * startS, yVelocity * startS);

    }

    //reset postion function
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("ResetZone"))
        {
            rb.linearVelocity = Vector2.zero;
            rb.position = startPos;
        }
        LaunchBall();
    }
}
