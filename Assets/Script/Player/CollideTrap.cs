using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideTrap : MonoBehaviour
{
    public Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "AllTrap")
        {
            /*rb.isKinematic = true;
            rb.velocity = Vector2.zero;*/
        }
    }
}
