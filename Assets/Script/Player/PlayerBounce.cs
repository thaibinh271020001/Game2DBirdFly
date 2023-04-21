using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBounce : MonoBehaviour
{
    private Rigidbody2D rb;
    private Rigidbody2D rb0;

    Vector3 lastVelocity;
    Vector2 vt = new Vector2(5f,10f);
    Vector2 vt1 = new Vector2(5f,10f);
    Vector2 vt2 = new Vector2(-5f,10f);

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        lastVelocity = rb.velocity;
        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<Rigidbody2D>().gravityScale = 2;
            rb.velocity = vt;
            Debug.Log(vt);

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        var speed = lastVelocity.magnitude;
        var direction = Vector3.Reflect(lastVelocity.normalized, collision.contacts[0].normal);

        rb.velocity = direction * speed;
        if(collision.gameObject.name == "Line2" || collision.gameObject.name == "Line4")
        {
            transform.Rotate(0, -180, 0);
        }

        if (collision.gameObject.name == "Line4")
        {
            vt = vt2;
        }
        if (collision.gameObject.name == "Line2")
        {
            vt = vt1;
        }
    }
}
