using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 5f;
    public float Jumpspeed = 12f;
    public float direction = 0f;
    public Rigidbody2D player;

    private Vector2 vt1;
    private Vector2 vt2;

    void Start()
    {
        player = GetComponent<Rigidbody2D>();
        vt1 = new Vector2(5f, Jumpspeed);
        vt2 = new Vector2(-5f, Jumpspeed);
    }

    void Update()
    {

        /*if (Input.GetMouseButtonDown(0))
        {
            GetComponent<Rigidbody2D>().gravityScale = 2;
            if (Mathf.Approximately(transform.eulerAngles.y, 180f))
            {
                player.velocity = vt2;

            }
            else
            {
                player.velocity = vt1;
            }
        }*/
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
}
