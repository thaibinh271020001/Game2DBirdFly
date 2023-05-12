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
}
