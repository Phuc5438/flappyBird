using UnityEngine;
using UnityEngine.InputSystem;


public class BirdController : MonoBehaviour
{
    public float jumpForce = 5f;

    private Rigidbody2D rb;
    private bool gameStarted = false;
    private Vector3 startPos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameStarted)
        {
            float floatY = Mathf.Sin(Time.time * 2f) * 0.5f;
            transform.position = startPos + new Vector3(0, floatY, 0);
        }

        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            if (!gameStarted)
            {
                gameStarted = true;
                rb.gravityScale = 1;
                transform.position = startPos;
            }

            rb.linearVelocity = Vector2.up * jumpForce;
        }
    }
}