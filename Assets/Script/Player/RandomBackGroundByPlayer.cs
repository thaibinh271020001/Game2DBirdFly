using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomBackGroundByPlayer : MonoBehaviour
{
    public Sprite[] sprites;
    void Start()
    {
        //GetComponent<SpriteRenderer>().sprite = sprites[Random.Range(0, sprites.Length)];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject otherGameObject = GameObject.Find("BackGround");
        SpriteRenderer spriteRenderer = otherGameObject.GetComponent<SpriteRenderer>();
        if(collision.gameObject.name == "Line2" || collision.gameObject.name == "Line4")
        {
            spriteRenderer.sprite = sprites[Random.Range(0, sprites.Length)];
        }
    }
}
