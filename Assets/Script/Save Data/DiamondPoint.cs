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
        Load();
        DiamondText.text = "" + Diamond;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Spawned")
        {
            Diamond++;
            DiamondText.text = "" + Diamond;
            PlayerPrefs.SetInt("DiamondP", Diamond);
        }
    }

    public void Load()
    {
        Diamond = PlayerPrefs.GetInt("DiamondP");
        Debug.Log("Point Diamond: " + PlayerPrefs.GetInt("DiamondP"));
    }

    public int RefDiamond()
    {
        return Diamond;
    }
}
