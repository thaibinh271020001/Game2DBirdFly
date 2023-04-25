using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Point : MonoBehaviour
{
    private PlayerToSpawnTrap PTST;
    public Text Score;

    public int DiamondPoint = 500;
    public Text Diamond;
    void Start()
    {
        PTST = GetComponent<PlayerToSpawnTrap>();
    }

    // Update is called once per frame
    void Update()
    {
        Score.text = "" + PTST.Point;
        Diamond.text = "" + DiamondPoint;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Spawned")
        {
            DiamondPoint++;
            Debug.Log("Diamond Point: " + DiamondPoint);
        }
    }
}
