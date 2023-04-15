using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public GameObject hideObject;
    public GameObject btnSetting;
    public GameObject btnADS;
    public GameObject btnLeaderboard;
    public GameObject btnShop;
    public GameObject textPoint;

    private Rigidbody2D rb;

    void Update()
    {
        clickToStart();
    }

    void clickToStart()
    {
        if (Input.GetMouseButtonDown(0))
        {
            hideObject.SetActive(false);
            btnSetting.SetActive(false);
            btnADS.SetActive(false);
            btnLeaderboard.SetActive(false);
            btnShop.SetActive(false);
            textPoint.SetActive(true);

        }
    }
}
