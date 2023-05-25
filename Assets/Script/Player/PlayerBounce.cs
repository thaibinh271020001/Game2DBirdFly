using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerBounce : MonoBehaviour
{
    private Rigidbody2D rb;

    public GameObject textPoint;
    public GameObject btnSetting;
    public GameObject btnLeaderboard;
    public GameObject btnShop;
    public GameObject btnADS;
    public GameObject PointText;

    public Animator anim;
    public Vector2 av;
    Vector3 lastVelocity;
    Vector2 vt = new Vector2(4f,11f);
    Vector2 vt1 = new Vector2(4f, 11f);
    Vector2 vt2 = new Vector2(-4f, 11f);

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        
        lastVelocity = rb.velocity;
        if(rb.velocity.y < 10f)
        {
            anim.SetTrigger("Fall");
        }
    }

    public void ClickToPlay()
    {
        anim.SetTrigger("Fly");
        GetComponent<Rigidbody2D>().gravityScale = 2.7f;
        rb.velocity = vt;

        btnSetting.SetActive(false);
        btnADS.SetActive(false);
        btnLeaderboard.SetActive(false);
        btnShop.SetActive(false);
        PointText.SetActive(false);
        textPoint.SetActive(true);
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

        if(collision.gameObject.tag == "AllTrap")
        {
            anim.SetTrigger("Colision");

        }

    }
}
