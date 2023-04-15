using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Button;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("click");
        }
    }

    public void whenButtonClicked()
    {
        if(Button.activeInHierarchy == true)
        {
            Button.SetActive(false);
        }
    }
}
