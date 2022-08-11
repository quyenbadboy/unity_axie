using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bong : MonoBehaviour
{
    public GameObject ball;
    public bool ball_gravity ;
    float ball_y;
    // Start is called before the first frame update
    Rigidbody2D body;
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        ball_y = ball.transform.position.y;
        Debug.Log(ball_gravity);
        if (ball_gravity)
        {
            body.gravityScale = -1;
        }
        if (ball_y > -1.77) {
            body.gravityScale = 1;
            ball_gravity = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "map")
        {
            ball_gravity = true;
        }
    }
}
