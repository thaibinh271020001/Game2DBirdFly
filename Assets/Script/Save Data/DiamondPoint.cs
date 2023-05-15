using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiamondPoint : MonoBehaviour
{
    static public int Diamond;
    public Text DiamondText;

    void Start()
    {
        Diamond = PlayerPrefs.GetInt("Money");
        DiamondText.text = "" + Diamond;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Spawned")
        {
            Diamond+=100;
            DiamondText.text = "" + Diamond;
            PlayerPrefs.SetInt("DiamondP1", Diamond);
            PlayerPrefs.SetInt("Money", Diamond);
        }
    }

    public void Load()
    {
        Diamond = PlayerPrefs.GetInt("DiamondP1");
        Debug.Log("Point Diamond: " + PlayerPrefs.GetInt("DiamondP1"));
    }

    public int RefDiamond()
    {
        return Diamond;
    }
}
