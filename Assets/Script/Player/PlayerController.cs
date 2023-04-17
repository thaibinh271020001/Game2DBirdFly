using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 5f;
    public float Jumpspeed = 12f;
    public float direction = 0f;
    public Rigidbody2D player;

    void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        direction = Input.GetAxis("Horizontal");
        /*isToochingGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);*/

        /*player.velocity = new Vector2(direction * speed, player.velocity.y);*/
        
        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<Rigidbody2D>().gravityScale = 2;
            if (Mathf.Approximately(transform.eulerAngles.y,180f))
            {
                player.velocity = new Vector2(-5f, Jumpspeed);
            }
            else
            {
                player.velocity = new Vector2(5f, Jumpspeed);
            }
        }
    }
}
