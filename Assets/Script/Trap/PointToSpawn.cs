using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointToSpawn : MonoBehaviour
{
    public GameObject Player;
    public int Point = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(Player.gameObject.tag == "AllLine")
        {
            Point++;
            Debug.Log(Point);
        }
    }
}
