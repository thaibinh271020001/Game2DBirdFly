using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public float jumpPower = 5.0f;
    public float moveSpeed = 5.0f;

    private bool canJump = true;
    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (canJump && Input.GetMouseButtonDown(0))
        {
            Jump();
        }
    }

    private void Jump()
    {
        canJump = false;
        rb.velocity = new Vector2(moveSpeed, jumpPower);
    }
}
