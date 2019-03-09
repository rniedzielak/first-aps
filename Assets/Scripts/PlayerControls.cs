using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControls : MonoBehaviour
{
    public Rigidbody2D rb;
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    private bool onGround;
    private Vector2 lastPositon;
    private float waitTime = 2.0f;
    private float timer = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.transform.position.x<0)
        {
            Points.score = 0;
        }
        else
        {
            Points.score = (int)rb.transform.position.x;
        }

        timer += Time.deltaTime;
        Vector2 currentPosition = new Vector2(-10, -10);
        if (timer > waitTime)
        {
            currentPosition = transform.position;
            timer = timer - waitTime;
            if (currentPosition.x == lastPositon.x)
            {
                Time.timeScale = 0;
                GameObject.Find("Button").transform.localScale = new Vector3(1, 1, 1);
            }
        }        
        if (rb.transform.position.y < -15)
        {
            Time.timeScale = 0;
            GameObject.Find("Button").transform.localScale = new Vector3(1, 1, 1);
        }
        if (rb.transform.position.x < 12)
        {
            rb.velocity = new Vector2(2, rb.velocity.y);

        }
        else if (rb.transform.position.x < 24)
        {
            rb.velocity = new Vector2(3, rb.velocity.y);
        }
        else
        {
            rb.velocity = new Vector2(4, rb.velocity.y);
        }
        onGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
        if (Input.GetMouseButtonDown(0) && onGround)
        {
            rb.velocity = new Vector2(rb.velocity.x, 5);
        }
        if (currentPosition != new Vector2(-10, -10))
        {
            lastPositon = currentPosition;
        }
    }    
}
