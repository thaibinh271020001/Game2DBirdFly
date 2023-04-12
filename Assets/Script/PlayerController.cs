using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public float Jumpspeed = 8f;
    public float direction = 0f;
    public Rigidbody2D player;

    /*public Transform groundCheck;
    public float groundCheckRadius = 0f;
    public LayerMask groundLayer;
    public bool isToochingGround;*/
    // Start is called before the first frame update

    void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        direction = Input.GetAxis("Horizontal");
        /*isToochingGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);*/


        player.velocity = new Vector2(direction * speed, player.velocity.y);

        if (Input.GetButtonDown("Jump") /*&& isToochingGround*/)
        {
            player.velocity = new Vector2(player.velocity.x, Jumpspeed);
        }

        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Line")
        {
            player.AddForce(-collision.contacts[0].normal * 20, ForceMode2D.Impulse);
            Debug.Log("Line");
        }
    }


}
