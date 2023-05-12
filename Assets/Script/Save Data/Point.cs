using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Point : MonoBehaviour
{
    private PlayerToSpawnTrap PTST;
    public Text[] Score = new Text[2];

    void Start()
    {
        PTST = GetComponent<PlayerToSpawnTrap>();
    }

    // Update is called once per frame
    void Update()
    {
        Score[0].text = "" + PTST.Point;
        Score[1].text = "" + PTST.Point;
    }
}
