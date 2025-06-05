using UnityEngine;

public class BallController : MonoBehaviour
{
    private Rigidbody2D rb;

    public Vector2 startingVelocity = new Vector2(5f, 5f);
    public float speedUp = 1.1f;

    public GameManager gameManager;

    public void ResetBall()
    {
        Vector3 ballPosition = new Vector3(0f, 1f, 0f);
        transform.position = ballPosition;

        if (rb == null) rb = GetComponent<Rigidbody2D>();
        rb.linearVelocity = startingVelocity;
    }

    //Colisão da bola com os GameObjects.
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Wall"))
        {
            Vector2 newVelocity = rb.linearVelocity;

            newVelocity.y = -newVelocity.y;
            rb.linearVelocity = newVelocity;
        }

        if (collision.transform.CompareTag("Player"))
        {
            rb.linearVelocity = new Vector2(-rb.linearVelocity.x, rb.linearVelocity.y);
            rb.linearVelocity *= speedUp;
        }

        if (collision.transform.CompareTag("PoiintZone01"))
        {
            gameManager.Player01EarnScore();
            ResetBall();
        }

        if (collision.transform.CompareTag("PointZone02"))
        {
            gameManager.Player02EarnScore();
            ResetBall();
        }
    }

}
