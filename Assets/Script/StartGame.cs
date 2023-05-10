using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    public GameObject hideObject;
    public GameObject btnSetting;
    public GameObject btnADS;
    public GameObject btnLeaderboard;
    public GameObject btnShop;
    public GameObject PointText;

    void Update()
    {
        clickToStart();
    }

    void clickToStart()
    {
        if (Input.GetMouseButtonDown(0))
        {
            hideObject.SetActive(false);
            /*btnSetting.SetActive(false);
            btnADS.SetActive(false);
            btnLeaderboard.SetActive(false);
            btnShop.SetActive(false);*/
            
        }
    }
}
