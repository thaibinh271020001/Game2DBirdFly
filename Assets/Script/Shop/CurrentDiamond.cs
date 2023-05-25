using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrentDiamond : MonoBehaviour
{
    public Text text;
    void Update()
    {
        text.text = "" + PlayerPrefs.GetInt("Money");
    }
}
