using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    public GameObject hideObject;

    void Update()
    {
        clickToStart();
    }

    void clickToStart()
    {
        if (Input.GetMouseButtonDown(0))
        {
            hideObject.SetActive(false);
            
        }
    }
}
